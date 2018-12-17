using System;
using System.Data;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRIFileContent
    {
		
        public bool GetData()
        {
            return Execute("SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) " + OrderBy());
        }
        
        public bool GetDataByID(Int64 pIDCRIFileContent)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE IDCRIFileContent = " + pIDCRIFileContent + " ";
            return Execute(sSQL);
        }

        public object Insert(tCRIFileContentRow pRow)
        {
            NewRow();

            Columns.IDCRIFile = pRow.IDCRIFile;
            Columns.dtmLoaded = pRow.dtmLoaded;
            Columns.intVersion = pRow.intVersion;
            Columns.intLength = pRow.intLength;
            Columns.intRead = pRow.intRead;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Models.tCRIFileContent pModel)
        {
            NewRow();

            Columns.IDCRIFile = pModel.IDCRIFile;
            Columns.dtmLoaded = pModel.dtmLoaded;
            Columns.intVersion = pModel.intVersion;
            Columns.intLength = pModel.intLength;
            Columns.intRead = pModel.intRead;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Int64 pIDCRIFile, DateTime pdtmLoaded, Int32 pintVersion, Int32 pintLength, Int32 pintRead)
        {
            NewRow();

            Columns.IDCRIFile = pIDCRIFile;
            Columns.dtmLoaded = pdtmLoaded;
            Columns.intVersion = pintVersion;
            Columns.intLength = pintLength;
            Columns.intRead = pintRead;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(tCRIFileContentRow pRow)
        {
            if (base.Eof() || (this.Columns.IDCRIFileContent != pRow.IDCRIFileContent ))
                GetDataByID(pRow.IDCRIFileContent);

            Columns.IDCRIFile = pRow.IDCRIFile;
            Columns.dtmLoaded = pRow.dtmLoaded;
            Columns.intVersion = pRow.intVersion;
            Columns.intLength = pRow.intLength;
            Columns.intRead = pRow.intRead;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Models.tCRIFileContent pModel)
        {
            if (base.Eof() || (this.Columns.IDCRIFileContent != pModel.IDCRIFileContent ))
                GetDataByID(pModel.IDCRIFileContent);

            Columns.IDCRIFile = pModel.IDCRIFile;
            Columns.dtmLoaded = pModel.dtmLoaded;
            Columns.intVersion = pModel.intVersion;
            Columns.intLength = pModel.intLength;
            Columns.intRead = pModel.intRead;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Int64 pIDCRIFileContent, Int64 pIDCRIFile, DateTime pdtmLoaded, Int32 pintVersion, Int32 pintLength, Int32 pintRead)
        {
            GetDataByID(pIDCRIFileContent);

            Columns.IDCRIFile = pIDCRIFile;
            Columns.dtmLoaded = pdtmLoaded;
            Columns.intVersion = pintVersion;
            Columns.intLength = pintLength;
            Columns.intRead = pintRead;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Delete(Int64 pIDCRIFileContent)
        {
            GetDataByID(pIDCRIFileContent);

            this.DeleteRow();

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

    }
}
