using System;
using System.Data;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tTypeParameter
    {
		
        public bool GetData()
        {
            return Execute("SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) " + OrderBy());
        }
        
        public bool GetDataByID(Int32 pIDTypeParameter)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE IDTypeParameter = " + pIDTypeParameter + " ";
            return Execute(sSQL);
        }

        public object Insert(tTypeParameterRow pRow)
        {
            NewRow();

            Columns.IDAUTOTypeParameter = pRow.IDAUTOTypeParameter;
            Columns.vchName = pRow.vchName;
            Columns.descTypeParameter = pRow.descTypeParameter;
            Columns.bitAcvive = pRow.bitAcvive;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Models.tTypeParameter pModel)
        {
            NewRow();

            Columns.IDAUTOTypeParameter = pModel.IDAUTOTypeParameter;
            Columns.vchName = pModel.vchName;
            Columns.descTypeParameter = pModel.descTypeParameter;
            Columns.bitAcvive = pModel.bitAcvive;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Int32? pIDAUTOTypeParameter, String pvchName, String pdescTypeParameter, Boolean pbitAcvive)
        {
            NewRow();

            Columns.IDAUTOTypeParameter = pIDAUTOTypeParameter;
            Columns.vchName = pvchName;
            Columns.descTypeParameter = pdescTypeParameter;
            Columns.bitAcvive = pbitAcvive;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(tTypeParameterRow pRow)
        {
            if (base.Eof() || (this.Columns.IDTypeParameter != pRow.IDTypeParameter ))
                GetDataByID(pRow.IDTypeParameter);

            Columns.IDAUTOTypeParameter = pRow.IDAUTOTypeParameter;
            Columns.vchName = pRow.vchName;
            Columns.descTypeParameter = pRow.descTypeParameter;
            Columns.bitAcvive = pRow.bitAcvive;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Models.tTypeParameter pModel)
        {
            if (base.Eof() || (this.Columns.IDTypeParameter != pModel.IDTypeParameter ))
                GetDataByID(pModel.IDTypeParameter);

            Columns.IDAUTOTypeParameter = pModel.IDAUTOTypeParameter;
            Columns.vchName = pModel.vchName;
            Columns.descTypeParameter = pModel.descTypeParameter;
            Columns.bitAcvive = pModel.bitAcvive;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Int32 pIDTypeParameter, Int32? pIDAUTOTypeParameter, String pvchName, String pdescTypeParameter, Boolean pbitAcvive)
        {
            GetDataByID(pIDTypeParameter);

            Columns.IDAUTOTypeParameter = pIDAUTOTypeParameter;
            Columns.vchName = pvchName;
            Columns.descTypeParameter = pdescTypeParameter;
            Columns.bitAcvive = pbitAcvive;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Delete(Int32 pIDTypeParameter)
        {
            GetDataByID(pIDTypeParameter);

            this.DeleteRow();

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

    }
}
