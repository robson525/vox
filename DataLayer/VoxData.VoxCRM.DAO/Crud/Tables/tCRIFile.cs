using System;
using System.Data;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRIFile
    {

        public bool GetData()
        {
            return Execute("SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) " + OrderBy());
        }

        public bool GetDataByID(Int64 pIDCRIFile)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE IDCRIFile = " + pIDCRIFile + " ";
            return Execute(sSQL);
        }

        public bool GetDataByFileName(String psvchFileName)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE vchFileName = " + psvchFileName.AddSingleQuotes() + " ";
            return Execute(sSQL);
        }

        public object Insert(tCRIFileRow pRow)
        {
            NewRow();

            Columns.vchFileName = pRow.vchFileName;
            Columns.dtmDateFile = pRow.dtmDateFile;
            Columns.bitClosed = pRow.bitClosed;
            Columns.intPointer = pRow.intPointer;
            Columns.intErrors = pRow.intErrors;
            Columns.vchType = pRow.vchType;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Models.tCRIFile pModel)
        {
            NewRow();

            Columns.vchFileName = pModel.vchFileName;
            Columns.dtmDateFile = pModel.dtmDateFile;
            Columns.bitClosed = pModel.bitClosed;
            Columns.intPointer = pModel.intPointer;
            Columns.intErrors = pModel.intErrors;
            Columns.vchType = pModel.vchType;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(String pvchFileName, DateTime pdtmDateFile, Boolean pbitClosed, Int32 pintPointer, Int32 pintErrors, String pvchType)
        {
            NewRow();

            Columns.vchFileName = pvchFileName;
            Columns.dtmDateFile = pdtmDateFile;
            Columns.bitClosed = pbitClosed;
            Columns.intPointer = pintPointer;
            Columns.intErrors = pintErrors;
            Columns.vchType = pvchType;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(String pvchFileName, DateTime pdtmDateFile, Boolean pbitClosed, String pvchType)
        {
            NewRow();

            Columns.vchFileName = pvchFileName;
            Columns.dtmDateFile = pdtmDateFile;
            Columns.bitClosed = pbitClosed;
            Columns.intPointer = 0;
            Columns.intErrors = 0;
            Columns.vchType = pvchType;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(tCRIFileRow pRow)
        {
            if (base.Eof() || (this.Columns.IDCRIFile != pRow.IDCRIFile))
                GetDataByID(pRow.IDCRIFile);

            Columns.vchFileName = pRow.vchFileName;
            Columns.dtmDateFile = pRow.dtmDateFile;
            Columns.bitClosed = pRow.bitClosed;
            Columns.intPointer = pRow.intPointer;
            Columns.intErrors = pRow.intErrors;
            Columns.vchType = pRow.vchType;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Models.tCRIFile pModel)
        {
            if (base.Eof() || (this.Columns.IDCRIFile != pModel.IDCRIFile))
                GetDataByID(pModel.IDCRIFile);

            Columns.vchFileName = pModel.vchFileName;
            Columns.dtmDateFile = pModel.dtmDateFile;
            Columns.bitClosed = pModel.bitClosed;
            Columns.intPointer = pModel.intPointer;
            Columns.intErrors = pModel.intErrors;
            Columns.vchType = pModel.vchType;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Int64 pIDCRIFile, String pvchFileName, DateTime pdtmDateFile, Boolean pbitClosed, Int32 pintPointer, Int32 pintErrors, String pvchType)
        {
            GetDataByID(pIDCRIFile);

            Columns.vchFileName = pvchFileName;
            Columns.dtmDateFile = pdtmDateFile;
            Columns.bitClosed = pbitClosed;
            Columns.intPointer = pintPointer;
            Columns.intErrors = pintErrors;
            Columns.vchType = pvchType;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(String pvchFileName, Boolean pbitClosed)
        {
            GetDataByFileName(pvchFileName);
            
            Columns.bitClosed = pbitClosed;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Delete(Int64 pIDCRIFile)
        {
            GetDataByID(pIDCRIFile);

            this.DeleteRow();

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

    }
}
