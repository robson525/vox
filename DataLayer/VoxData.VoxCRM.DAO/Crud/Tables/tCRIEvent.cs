using System;
using System.Data;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRIEvent
    {
		
        public bool GetData()
        {
            return Execute("SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) " + OrderBy());
        }
        
        public bool GetDataByID(Int64 pIDCRIEvent)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE IDCRIEvent = " + pIDCRIEvent + " ";
            return Execute(sSQL);
        }

        public object Insert(tCRIEventRow pRow)
        {
            NewRow();

            Columns.IDCRIFile = pRow.IDCRIFile;
            Columns.intDateTicket = pRow.intDateTicket;
            Columns.sintObjectId = pRow.sintObjectId;
            Columns.intDate = pRow.intDate;
            Columns.chrState = pRow.chrState;
            Columns.chrInfo = pRow.chrInfo;
            Columns.sintTeam = pRow.sintTeam;
            Columns.dtmLoaded = pRow.dtmLoaded;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Models.tCRIEvent pModel)
        {
            NewRow();

            Columns.IDCRIFile = pModel.IDCRIFile;
            Columns.intDateTicket = pModel.intDateTicket;
            Columns.sintObjectId = pModel.sintObjectId;
            Columns.intDate = pModel.intDate;
            Columns.chrState = pModel.chrState;
            Columns.chrInfo = pModel.chrInfo;
            Columns.sintTeam = pModel.sintTeam;
            Columns.dtmLoaded = pModel.dtmLoaded;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Int64 pIDCRIFile, Int32? pintDateTicket, Int16? psintObjectId, Int32? pintDate, String pchrState, String pchrInfo, Int16? psintTeam, DateTime? pdtmLoaded)
        {
            NewRow();

            Columns.IDCRIFile = pIDCRIFile;
            Columns.intDateTicket = pintDateTicket;
            Columns.sintObjectId = psintObjectId;
            Columns.intDate = pintDate;
            Columns.chrState = pchrState;
            Columns.chrInfo = pchrInfo;
            Columns.sintTeam = psintTeam;
            Columns.dtmLoaded = pdtmLoaded;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(tCRIEventRow pRow)
        {
            if (base.Eof() || (this.Columns.IDCRIEvent != pRow.IDCRIEvent ))
                GetDataByID(pRow.IDCRIEvent);

            Columns.IDCRIFile = pRow.IDCRIFile;
            Columns.intDateTicket = pRow.intDateTicket;
            Columns.sintObjectId = pRow.sintObjectId;
            Columns.intDate = pRow.intDate;
            Columns.chrState = pRow.chrState;
            Columns.chrInfo = pRow.chrInfo;
            Columns.sintTeam = pRow.sintTeam;
            Columns.dtmLoaded = pRow.dtmLoaded;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Models.tCRIEvent pModel)
        {
            if (base.Eof() || (this.Columns.IDCRIEvent != pModel.IDCRIEvent ))
                GetDataByID(pModel.IDCRIEvent);

            Columns.IDCRIFile = pModel.IDCRIFile;
            Columns.intDateTicket = pModel.intDateTicket;
            Columns.sintObjectId = pModel.sintObjectId;
            Columns.intDate = pModel.intDate;
            Columns.chrState = pModel.chrState;
            Columns.chrInfo = pModel.chrInfo;
            Columns.sintTeam = pModel.sintTeam;
            Columns.dtmLoaded = pModel.dtmLoaded;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Int64 pIDCRIEvent, Int64 pIDCRIFile, Int32? pintDateTicket, Int16? psintObjectId, Int32? pintDate, String pchrState, String pchrInfo, Int16? psintTeam, DateTime? pdtmLoaded)
        {
            GetDataByID(pIDCRIEvent);

            Columns.IDCRIFile = pIDCRIFile;
            Columns.intDateTicket = pintDateTicket;
            Columns.sintObjectId = psintObjectId;
            Columns.intDate = pintDate;
            Columns.chrState = pchrState;
            Columns.chrInfo = pchrInfo;
            Columns.sintTeam = psintTeam;
            Columns.dtmLoaded = pdtmLoaded;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Delete(Int64 pIDCRIEvent)
        {
            GetDataByID(pIDCRIEvent);

            this.DeleteRow();

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

    }
}
