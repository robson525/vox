using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using SevenZipLib;
using VoxData.Shared.Functions;
using VoxData.VoxCRM.DAO.Tables;

namespace VoxData.VoxCRM.Service.CRIStatistics
{
    internal class Transfer
    {
        private Log objLog;
        private string sFTP_A;
        private string sFTP_B;
        private string sFTP_User;
        private string sFTP_Pass;
        private string sFilesPath;
        private string sCurrentServerFTP;
        private bool bCurrentServerChanged;
        private List<string> sCRIFiles;

        private readonly string[] sExtensions = new string[] { ".sta", ".Z" };
        private readonly string[] sTypes = new string[] { "tc", "ev", "te" };

        public bool bTransfering { get; private set; }

        public Transfer(Log poLog, string psFTP_A, string psFTP_B, string psFTP_User, string psFTP_Pass, string psFilesPath)
        {
            this.objLog = poLog;
            this.sFTP_A = psFTP_A;
            this.sFTP_B = psFTP_B;
            this.sFTP_User = psFTP_User;
            this.sFTP_Pass = psFTP_Pass;
            this.sFilesPath = psFilesPath;
            this.sCurrentServerFTP = this.sFTP_A;

            if (!Directory.Exists(this.sFilesPath))
                Directory.CreateDirectory(this.sFilesPath);

            this.bTransfering = false;
            this.bCurrentServerChanged = false;

            tCRIFile tCriFile = new tCRIFile();
            try
            {
                tCriFile.GetData();
                this.sCRIFiles = tCriFile.Table.Where(_ => _.bitClosed).Select(_ => _.vchFileName).ToList();
            }
            finally
            {
                tCriFile.Dispose();
            }
        }

        public void InitTransfer()
        {
            if (CRIService.bStoping || this.bTransfering)
                return;

            this.bTransfering = true;
            this.objLog.GravarLog(Log.TypeMessage.Message, "Initiating Transfer");

            this.bCurrentServerChanged = false;
            this.Process();

            this.objLog.GravarLog(Log.TypeMessage.Message, "Transfer Finished");
            this.bTransfering = false;
        }

        private void Process()
        {
            try
            {
                List<string> files = this.LoadValidFiles();
                this.objLog.GravarLog(Log.TypeMessage.Message, files.Count + " valid files");

                files.ForEach(file =>
                {
                    string extension = Path.GetExtension(file).ToLower();
                    string type = file.Substring(0, 2).ToLower();

                    bool copy = this.CopyFile(file, this.sFilesPath, true);

                    if (copy && type != "ca")
                    {
                        bool close = false;
                        if (extension == ".z")
                        {
                            close = true;
                            this.UnzipFile(ref file);
                        }
                        else if (type == "ev")
                            close = true;

                        this.InsertDataBase(file, type, close);

                        if (close)
                            this.sCRIFiles.Add(file);
                    }
                });
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, ex.Message + " | " + ex.StackTrace);
            }
        }

        private bool CopyFile(string psFile, string psDestination, bool pbShowLog)
        {
            bool ret = false;
            FtpWebRequest request = null;
            FtpWebResponse response = null;
            Stream responseStream = null;
            FileStream newFile = null;
            try
            {
                if (pbShowLog)
                    this.objLog.GravarLog(Log.TypeMessage.Message, "Transferring File \"" + psFile + "\"");

                request = (FtpWebRequest)WebRequest.Create(this.sCurrentServerFTP + "/" + psFile);
                request.Credentials = new NetworkCredential(this.sFTP_User, this.sFTP_Pass);
                request.UsePassive = false;
                request.UseBinary = true;
                request.KeepAlive = false;
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                response = (FtpWebResponse)request.GetResponse();
                responseStream = response.GetResponseStream();

                byte[] buffer = new byte[8192];

                newFile = new FileStream(psDestination + @"\" + psFile, FileMode.Create);

                int readCount = responseStream.Read(buffer, 0, buffer.Length);

                while (readCount > 0)
                {
                    newFile.Write(buffer, 0, readCount);
                    readCount = responseStream.Read(buffer, 0, buffer.Length);
                }

                if (pbShowLog)
                    this.objLog.GravarLog(Log.TypeMessage.Success, "Transferred File \"" + psFile + "\".");

                ret = true;
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, ex.Message + " | " + ex.StackTrace);
            }
            finally
            {
                newFile?.Close();
                responseStream?.Close();
                response?.Close();
            }

            return ret;
        }

        private void InsertDataBase(string psFile, string psType, bool pbClosed)
        {
            tCRIFile tCriFile = new tCRIFile();
            try
            {
                tCriFile.GetDataByFileName(psFile);
                if (tCriFile.Table.Count == 0)
                {
                    if (pbClosed && psType == "te")
                        return;

                    DateTime dtFile = DateTime.ParseExact(psFile.Substring(2, 6), "yyMMdd", CultureInfo.InvariantCulture);
                    tCriFile.Insert(psFile, dtFile, pbClosed, psType);
                    this.objLog.GravarLog(Log.TypeMessage.Success, "File \"" + psFile + "\" inserted. Closed {" + pbClosed + "}.");

                    if (psType == "ev")
                    {
                        string teFile = psFile.Replace("ev", "te");
                        this.InsertDataBase(teFile, "te", true);
                    }
                }
                else
                {
                    if (tCriFile.Columns.bitClosed)
                    {
                        throw new Exception("File \"" + psFile + "\" already closed.");
                    }
                    else if (pbClosed && !tCriFile.Columns.bitClosed)
                    {
                        tCriFile.Columns.bitClosed = true;
                        tCriFile.Apply();
                        this.objLog.GravarLog(Log.TypeMessage.Success, "File \"" + psFile + "\" closed.");
                    }
                }
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, ex.Message + " | " + ex.StackTrace);
            }
        }

        private List<string> LoadValidFiles()
        {
            List<string> serverFiles = this.LoadList();

            if (serverFiles.Count == 0)
            {
                this.objLog.GravarLog(Log.TypeMessage.Warn, "No found files.");
                return new List<string>();
            }

            this.objLog.GravarLog(Log.TypeMessage.Message, serverFiles.Count + " files in FTP server");

            List<string> files = serverFiles
                .Where(x => x == "catalog.cfg")
                .Concat(
                    serverFiles
                        .Where(_ => _.Length > 8)
                        .Select(_ => new { Name = Path.GetFileNameWithoutExtension(_), Extension = Path.GetExtension(_), Type = _.Substring(0, 2) })
                        .Where(_ => this.sExtensions.Contains(_.Extension) && this.sTypes.Contains(_.Type))
                        .Where(_ => !this.sCRIFiles.Contains(_.Name + _.Extension))
                        .Where(_ => _.Extension != ".Z" || (_.Extension == ".Z" && !this.sCRIFiles.Contains(_.Name + ".sta")))
                        .Where(_ => _.Type != "te" || (_.Type == "te" && !this.sCRIFiles.Contains(_.Name.Replace("te", "ev") + ".sta")))
                        .OrderBy(_ => DateTime.ParseExact(_.Name.Substring(2, 6), "yyMMdd", CultureInfo.InstalledUICulture))
                        .ThenBy(_ => _.Type == "tc" && _.Extension == ".Z")
                        .ThenBy(_ => _.Type == "tc" && _.Extension == ".sta")
                        .ThenBy(_ => _.Type == "ev")
                        .ThenBy(_ => _.Type == "te")
                        .Select(_ => _.Name + _.Extension)
                ).ToList();

            return files;
        }

        private List<string> LoadList(bool details = false)
        {
            this.objLog.GravarLog(Log.TypeMessage.Message, "Trying connect to FTP server {" + this.sCurrentServerFTP + "}");

            List<string> files = new List<string>();
            FtpWebRequest request = null;
            FtpWebResponse response = null;
            Stream responseStream = null;

            try
            {
                request = (FtpWebRequest)WebRequest.Create(this.sCurrentServerFTP);

                request.Credentials = new NetworkCredential(this.sFTP_User, this.sFTP_Pass);
                request.UsePassive = false;
                request.UseBinary = true;
                request.KeepAlive = false;

                request.Method = details ? WebRequestMethods.Ftp.ListDirectoryDetails : WebRequestMethods.Ftp.ListDirectory;

                using (response = (FtpWebResponse)request.GetResponse())
                {
                    responseStream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        this.objLog.GravarLog(Log.TypeMessage.Message, "Getting list of files.");
                        files = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                    }
                }
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, "Couldn't communicate for the FTP server " + this.sCurrentServerFTP + " (" + ex.Message + ") | " + ex.StackTrace);

                if (this.sCurrentServerFTP == this.sFTP_A)
                    this.sCurrentServerFTP = this.sFTP_B;
                else if (this.sCurrentServerFTP == this.sFTP_B)
                    this.sCurrentServerFTP = this.sFTP_A;

                bool changed = this.bCurrentServerChanged;
                this.bCurrentServerChanged = true;

                if (!changed)//if not changed before, try get again 
                    return this.LoadList();
            }
            finally
            {
                responseStream?.Close();
                response?.Close();
            }

            return files;
        }

        private void UnzipFile(ref string psFile)
        {
            try
            {
                this.objLog.GravarLog(Log.TypeMessage.Message, "Unziping file " + psFile);

                string zipFile = Path.Combine(this.sFilesPath, psFile);
                string unzipedFile = Path.Combine(this.sFilesPath, Path.GetFileNameWithoutExtension(psFile));
                psFile = Path.GetFileNameWithoutExtension(psFile) + ".sta";
                string stafile = Path.Combine(this.sFilesPath, psFile);

                using (SevenZipArchive archive = new SevenZipArchive(zipFile, ArchiveFormat.Zip))//TODO mudar o tipo de zip para Z
                {
                    archive.ExtractAll(this.sFilesPath);
                }

                File.Copy(unzipedFile, stafile, true);
                File.Delete(unzipedFile);
                File.Delete(zipFile);

                this.objLog.GravarLog(Log.TypeMessage.Success, "Unziped file " + psFile);
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, ex.Message + " | " + ex.StackTrace);
            }
        }

        internal void BackupOtherFiles()
        {
            try
            {
                this.objLog.GravarLog(Log.TypeMessage.ThinLine, "");
                this.objLog.GravarLog(Log.TypeMessage.Message, "Backing Up Other Files");

                string filesPath = Path.Combine(this.sFilesPath, "BACKUP");
                if (!Directory.Exists(filesPath))
                    Directory.CreateDirectory(filesPath);

                int transferred = 0;
                int erros = 0;
                string extensionTypeAnt = "";
                List<string> files = this.LoadList(true);

                foreach (string file in files)
                {
                    try
                    {
                        String[] split = file.Split(' ').Where(x => !String.IsNullOrEmpty(x)).ToArray();

                        String name = split[split.Length - 1];
                        String year = split[split.Length - 2];
                        String day = split[split.Length - 3];
                        String month = split[split.Length - 4];
                        String size = split[split.Length - 5];

                        String date = day.PadLeft(2, '0') + " " + month + (year.IndexOf(":") > 0 ? " " + DateTime.Now.Year : "") + " " + year;

                        string extension = Path.GetExtension(name).ToLower();
                        string type = name.Substring(0, 2).ToLower();

                        if (!(this.sExtensions.Contains(extension) && this.sTypes.Contains(type) || name == "catalog.cfg"))
                        {
                            string extensionType = extension.Remove(0, 1).ToUpper();
                            int aux;
                            if (String.IsNullOrEmpty(extension))
                            {
                                extensionType = "NO_EXTENSION";
                            }
                            else if (int.TryParse(extensionType, out aux))
                            {
                                extensionType = "NUMERIC";
                            }

                            string path = Path.Combine(filesPath, extensionType);
                            DateTime yesterday = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                DateTime.Now.Day - 1);

                            String dateFormat = "dd MMM yyyy" + (year.IndexOf(":") > 0 ? " HH:mm" : "");
                            DateTime dateModified = DateTime.ParseExact(date, dateFormat, CultureInfo.InvariantCulture);

                            if (extensionType != extensionTypeAnt)
                            {
                                this.objLog.GravarLog(Log.TypeMessage.Message, "Copping files: " + extensionType);
                                extensionTypeAnt = extensionType;
                            }

                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }

                            if (this.CopyFile(name, path, false))
                                transferred++;
                            else
                                erros++;
                        }
                        else
                        {
                            erros++;
                        }
                    }
                    catch (Exception)
                    {
                        erros++;
                    }
                }

                this.objLog.GravarLog(Log.TypeMessage.Message, "Found files:" + files.Count);
                this.objLog.GravarLog(Log.TypeMessage.Message, "Transferred files:" + transferred);
                this.objLog.GravarLog(Log.TypeMessage.Message, "Not Transferred files:" + erros);
                this.objLog.GravarLog(Log.TypeMessage.ThinLine, "");
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, ex.Message + " | " + ex.StackTrace);
            }
        }
    }
}
