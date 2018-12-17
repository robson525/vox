using System;
using System.IO;
using System.ServiceProcess;
using System.Timers;
using VoxData.Shared.Functions;
using VoxData.VoxCRM.DAO.Tables;
using VoxData.VoxCRM.GeneralFunctions;
using VoxData.VoxCRM.Service.CRIStatistics.Properties;

namespace VoxData.VoxCRM.Service.CRIStatistics
{
    public partial class CRIService : ServiceBase
    {
        public static bool bStoping;

        private Log objLog;
        private Transfer objTransfer;
        private Reader objReader;
        private Timer tTransferTime;
        private DateTime dtLastElapse;

        #region Parameters

        private string sLogPath;
        private TimeSpan tsTimeTransfer;
        private string sFilesPath;
        private string sFTP_A;
        private string sFTP_B;
        private string sFTP_User;
        private string sFTP_Pass;
        private bool sFTP_Backup;

        #endregion

        public CRIService()
        {
            InitializeComponent();

            this.sLogPath = Settings.Default.LogPath;
            if (string.IsNullOrEmpty(this.sLogPath.Trim()) || !Directory.Exists(this.sLogPath))
                this.sLogPath = Path.Combine(Environment.CurrentDirectory, "Logs");
            this.objLog = new Log(nameof(CRIService), this.sLogPath);

            this.objLog.GravarLog(Log.TypeMessage.Line, "");
            this.objLog.GravarLog(Log.TypeMessage.Center, base.ServiceName);
            this.objLog.GravarLog(Log.TypeMessage.Line, "");
        }

        protected override void OnStart(string[] args)
        {
            this.Start();
        }

        public void Start()
        {
            this.objLog.GravarLog(Log.TypeMessage.Success, "Starting");

            bStoping = false;
            this.LoadParameters();

            this.objTransfer = new Transfer(this.objLog, this.sFTP_A, this.sFTP_B, this.sFTP_User, this.sFTP_Pass, this.sFilesPath);
            this.objReader = new Reader(this.objLog);

            this.tTransferTime = new Timer();
            this.tTransferTime.Interval = this.tsTimeTransfer.TotalMilliseconds;
            this.tTransferTime.Elapsed += TransferTimeOnElapsed;

            this.dtLastElapse = DateTime.Now.Date;
            this.tTransferTime.Start();
            this.TransferTimeOnElapsed(null, null);
        }

        private void LoadParameters()
        {
            this.objLog.GravarLog(Log.TypeMessage.Center, "Loading Parameters");
            this.objLog.GravarLog(Log.TypeMessage.ThinLine, "");

            this.objLog.GravarLog("LogPath", this.sLogPath, false);

            try
            {
                tParameter.tParameterTable table = Parameter.getAll("SERVICE_CRI_");

                this.tsTimeTransfer = Parameter.getTime("SERVICE_CRI_TRANSFER_TIME", table);
                this.objLog.GravarLog("TimeTransfer", this.tsTimeTransfer.ToString(), false);

                this.sFilesPath = Parameter.getString("SERVICE_CRI_FILE_PATH", table);
                this.objLog.GravarLog("FilesPath", this.sFilesPath, false);

                this.sFTP_A = Parameter.getString("SERVICE_CRI_FTP_A", table);
                this.objLog.GravarLog("FTP_A", this.sFTP_A, false);

                this.sFTP_B = Parameter.getString("SERVICE_CRI_FTP_B", table);
                this.objLog.GravarLog("FTP_B", this.sFTP_B, false);

                this.sFTP_User = Parameter.getString("SERVICE_CRI_FTP_USER", table);
                this.objLog.GravarLog("FTP_User", this.sFTP_User, false);

                this.sFTP_Pass = Parameter.getString("SERVICE_CRI_FTP_PASSWORD", table);
                this.objLog.GravarLog("FTP_Pass", this.sFTP_Pass, false);
                this.sFTP_Pass = Criptografia.Descriptografar(this.sFTP_Pass);

                this.sFTP_Backup = Parameter.getBool("SERVICE_CRI_BACKUP_OTHER_FILES", table);
                this.objLog.GravarLog("FTP_Backup", this.sFTP_Backup.ToString(), false);
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, ex.Message + " | " + ex.StackTrace);
            }
        }

        private void TransferTimeOnElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                this.objTransfer.InitTransfer();
                this.objReader.InitReader();

                if (DateTime.Now.Date > this.dtLastElapse)
                {
                    if (this.sFTP_Backup)
                        this.objTransfer.BackupOtherFiles();
                }
            }
            catch (Exception ex)
            {
                this.objLog.GravarLog(Log.TypeMessage.Error, ex.Message + " | " + ex.StackTrace);
            }
        }

        protected override void OnStop()
        {
            bStoping = true;
            this.objLog.GravarLog(Log.TypeMessage.Message, "Stopping");

            while (this.objTransfer.bTransfering || this.objReader.bReading)
            {
                System.Threading.Thread.Sleep(5000);
            }

            this.objLog.GravarLog(Log.TypeMessage.Message, "Stopped");
            this.objLog.GravarLog(Log.TypeMessage.ThinLine, "");
            this.tTransferTime.Stop();
            this.tTransferTime = null;
            this.objTransfer = null;
            this.Dispose();
        }
    }
}
