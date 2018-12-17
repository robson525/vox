using System;
using System.Data;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRICatalog
    {
		
        public bool GetData()
        {
            return Execute("SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) " + OrderBy());
        }
        
        public bool GetDataByID(Int16 psintObjectId)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE sintObjectId = " + psintObjectId + " ";
            return Execute(sSQL);
        }

        public object Insert(tCRICatalogRow pRow)
        {
            NewRow();

            Columns.sintObjectId = pRow.sintObjectId;
            Columns.sintIdCl = pRow.sintIdCl;
            Columns.vchIdMao = pRow.vchIdMao;
            Columns.chrObjectType = pRow.chrObjectType;
            Columns.vchMatricule = pRow.vchMatricule;
            Columns.intCreateDate = pRow.intCreateDate;
            Columns.intDeleteDate = pRow.intDeleteDate;
            Columns.dtmCreateDate = pRow.dtmCreateDate;
            Columns.dtmDeleteDate = pRow.dtmDeleteDate;
            Columns.dtmLoaded = pRow.dtmLoaded;
            Columns.bitVisible = pRow.bitVisible;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Models.tCRICatalog pModel)
        {
            NewRow();

            Columns.sintObjectId = pModel.sintObjectId;
            Columns.sintIdCl = pModel.sintIdCl;
            Columns.vchIdMao = pModel.vchIdMao;
            Columns.chrObjectType = pModel.chrObjectType;
            Columns.vchMatricule = pModel.vchMatricule;
            Columns.intCreateDate = pModel.intCreateDate;
            Columns.intDeleteDate = pModel.intDeleteDate;
            Columns.dtmCreateDate = pModel.dtmCreateDate;
            Columns.dtmDeleteDate = pModel.dtmDeleteDate;
            Columns.dtmLoaded = pModel.dtmLoaded;
            Columns.bitVisible = pModel.bitVisible;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Int16 psintObjectId, Int16 psintIdCl, String pvchIdMao, String pchrObjectType, String pvchMatricule, Int32 pintCreateDate, Int32 pintDeleteDate, DateTime pdtmCreateDate, DateTime? pdtmDeleteDate, DateTime pdtmLoaded, Boolean pbitVisible)
        {
            NewRow();

            Columns.sintObjectId = psintObjectId;
            Columns.sintIdCl = psintIdCl;
            Columns.vchIdMao = pvchIdMao;
            Columns.chrObjectType = pchrObjectType;
            Columns.vchMatricule = pvchMatricule;
            Columns.intCreateDate = pintCreateDate;
            Columns.intDeleteDate = pintDeleteDate;
            Columns.dtmCreateDate = pdtmCreateDate;
            Columns.dtmDeleteDate = pdtmDeleteDate;
            Columns.dtmLoaded = pdtmLoaded;
            Columns.bitVisible = pbitVisible;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(tCRICatalogRow pRow)
        {
            if (base.Eof() || (this.Columns.sintObjectId != pRow.sintObjectId ))
                GetDataByID(pRow.sintObjectId);

            Columns.sintObjectId = pRow.sintObjectId;
            Columns.sintIdCl = pRow.sintIdCl;
            Columns.vchIdMao = pRow.vchIdMao;
            Columns.chrObjectType = pRow.chrObjectType;
            Columns.vchMatricule = pRow.vchMatricule;
            Columns.intCreateDate = pRow.intCreateDate;
            Columns.intDeleteDate = pRow.intDeleteDate;
            Columns.dtmCreateDate = pRow.dtmCreateDate;
            Columns.dtmDeleteDate = pRow.dtmDeleteDate;
            Columns.dtmLoaded = pRow.dtmLoaded;
            Columns.bitVisible = pRow.bitVisible;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Models.tCRICatalog pModel)
        {
            if (base.Eof() || (this.Columns.sintObjectId != pModel.sintObjectId ))
                GetDataByID(pModel.sintObjectId);

            Columns.sintObjectId = pModel.sintObjectId;
            Columns.sintIdCl = pModel.sintIdCl;
            Columns.vchIdMao = pModel.vchIdMao;
            Columns.chrObjectType = pModel.chrObjectType;
            Columns.vchMatricule = pModel.vchMatricule;
            Columns.intCreateDate = pModel.intCreateDate;
            Columns.intDeleteDate = pModel.intDeleteDate;
            Columns.dtmCreateDate = pModel.dtmCreateDate;
            Columns.dtmDeleteDate = pModel.dtmDeleteDate;
            Columns.dtmLoaded = pModel.dtmLoaded;
            Columns.bitVisible = pModel.bitVisible;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Int16 psintObjectId, Int16 psintIdCl, String pvchIdMao, String pchrObjectType, String pvchMatricule, Int32 pintCreateDate, Int32 pintDeleteDate, DateTime pdtmCreateDate, DateTime? pdtmDeleteDate, DateTime pdtmLoaded, Boolean pbitVisible)
        {
            GetDataByID(psintObjectId);

            Columns.sintObjectId = psintObjectId;
            Columns.sintIdCl = psintIdCl;
            Columns.vchIdMao = pvchIdMao;
            Columns.chrObjectType = pchrObjectType;
            Columns.vchMatricule = pvchMatricule;
            Columns.intCreateDate = pintCreateDate;
            Columns.intDeleteDate = pintDeleteDate;
            Columns.dtmCreateDate = pdtmCreateDate;
            Columns.dtmDeleteDate = pdtmDeleteDate;
            Columns.dtmLoaded = pdtmLoaded;
            Columns.bitVisible = pbitVisible;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Delete(Int16 psintObjectId)
        {
            GetDataByID(psintObjectId);

            this.DeleteRow();

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

    }
}
