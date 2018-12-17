using System;
using System.Data;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tParameter
    {
		
        public bool GetData()
        {
            return Execute("SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) " + OrderBy());
        }
        
        public bool GetDataByID(String pIDParameter)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE IDParameter = " + pIDParameter + " ";
            return Execute(sSQL);
        }

        public bool GetDataLike(String pIDParameter)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE IDParameter LIKE " + pIDParameter.AddLikeOperator(false, true, true);
            return Execute(sSQL);
        }

        public object Insert(tParameterRow pRow)
        {
            NewRow();

            Columns.IDParameter = pRow.IDParameter;
            Columns.IDTypeParameter = pRow.IDTypeParameter;
            Columns.vchValue = pRow.vchValue;
            Columns.vchTypeValue = pRow.vchTypeValue;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Models.tParameter pModel)
        {
            NewRow();

            Columns.IDParameter = pModel.IDParameter;
            Columns.IDTypeParameter = pModel.IDTypeParameter;
            Columns.vchValue = pModel.vchValue;
            Columns.vchTypeValue = pModel.vchTypeValue;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(String pIDParameter, Int32? pIDTypeParameter, String pvchValue, String pvchTypeValue)
        {
            NewRow();

            Columns.IDParameter = pIDParameter;
            Columns.IDTypeParameter = pIDTypeParameter;
            Columns.vchValue = pvchValue;
            Columns.vchTypeValue = pvchTypeValue;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(String pIDParameter, String pvchValue, String pvchTypeValue)
        {
            NewRow();

            Columns.IDParameter = pIDParameter;
            Columns.vchValue = pvchValue;
            Columns.vchTypeValue = pvchTypeValue;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(tParameterRow pRow)
        {
            if (base.Eof() || (this.Columns.IDParameter != pRow.IDParameter ))
                GetDataByID(pRow.IDParameter);

            Columns.IDParameter = pRow.IDParameter;
            Columns.IDTypeParameter = pRow.IDTypeParameter;
            Columns.vchValue = pRow.vchValue;
            Columns.vchTypeValue = pRow.vchTypeValue;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Models.tParameter pModel)
        {
            if (base.Eof() || (this.Columns.IDParameter != pModel.IDParameter ))
                GetDataByID(pModel.IDParameter);

            Columns.IDParameter = pModel.IDParameter;
            Columns.IDTypeParameter = pModel.IDTypeParameter;
            Columns.vchValue = pModel.vchValue;
            Columns.vchTypeValue = pModel.vchTypeValue;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(String pIDParameter, Int32? pIDTypeParameter, String pvchValue, String pvchTypeValue)
        {
            GetDataByID(pIDParameter);

            Columns.IDParameter = pIDParameter;
            Columns.IDTypeParameter = pIDTypeParameter;
            Columns.vchValue = pvchValue;
            Columns.vchTypeValue = pvchTypeValue;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(String pIDParameter, String pvchValue, String pvchTypeValue)
        {
            GetDataByID(pIDParameter);

            Columns.IDParameter = pIDParameter;
            Columns.vchValue = pvchValue;
            Columns.vchTypeValue = pvchTypeValue;

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Delete(String pIDParameter)
        {
            GetDataByID(pIDParameter);

            this.DeleteRow();

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

    }
}
