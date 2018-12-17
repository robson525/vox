using System;
using System.Data;
using System.Collections.Generic;
using VoxData.Shared.Functions;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tTypeParameter: TTableSQL
    {
		#region DataTable
		[Serializable()]
        public class tTypeParameterTable : TypedTableBase<tTypeParameterRow>
        {
			public DataColumn cIDTypeParameter { get; private set; }
            public DataColumn cIDAUTOTypeParameter { get; private set; }
            public DataColumn cvchName { get; private set; }
            public DataColumn cdescTypeParameter { get; private set; }
            public DataColumn cbitAcvive { get; private set; }
            

			public tTypeParameterTable()
            {
                this.TableName = "tTypeParameter";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

			[global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

			public tTypeParameterRow this[int index]
            {
                get
                {
                    return ((tTypeParameterRow)(this.Rows[index]));
                }
            }

			protected override DataTable CreateInstance()
            {
                return new tTypeParameterTable();
            }

			private void InitClass()
            {
				this.cIDTypeParameter = new DataColumn("IDTypeParameter", typeof(Int32), null, MappingType.Element);
                this.cIDTypeParameter.AllowDBNull = false;
                this.cIDTypeParameter.AutoIncrement = true;
                this.cIDTypeParameter.AutoIncrementSeed = -1;
                this.cIDTypeParameter.AutoIncrementStep = -1;
                this.cIDTypeParameter.ExtendedProperties.Add("PrimaryKey", "true");
                base.Columns.Add(this.cIDTypeParameter);
                this.cIDAUTOTypeParameter = new DataColumn("IDAUTOTypeParameter", typeof(Int32), null, MappingType.Element);
                this.cIDAUTOTypeParameter.AllowDBNull = true;
                this.cIDAUTOTypeParameter.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cIDAUTOTypeParameter);
                this.cvchName = new DataColumn("vchName", typeof(String), null, MappingType.Element);
                this.cvchName.AllowDBNull = false;
                this.cvchName.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchName);
                this.cdescTypeParameter = new DataColumn("descTypeParameter", typeof(String), null, MappingType.Element);
                this.cdescTypeParameter.AllowDBNull = true;
                this.cdescTypeParameter.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdescTypeParameter);
                this.cbitAcvive = new DataColumn("bitAcvive", typeof(Boolean), null, MappingType.Element);
                this.cbitAcvive.AllowDBNull = false;
                this.cbitAcvive.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cbitAcvive);
                
			}

			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new tTypeParameterRow(builder);
            }

            protected override global::System.Type GetRowType()
            {
                return typeof(tTypeParameterRow);
            }

            public tTypeParameterRow NewRow()
            {
                return (tTypeParameterRow)base.NewRow();
            }
		}
		#endregion

		#region DataRow
		[Serializable()]
        public class tTypeParameterRow : DataRow
        {
			private tTypeParameterTable tabletTypeParameter;

			internal tTypeParameterRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletTypeParameter = ((tTypeParameterTable)(this.Table));
            }


			public Int32 IDTypeParameter{
get { return ((Int32)(this[this.tabletTypeParameter.cIDTypeParameter])); }
set{ this[this.tabletTypeParameter.cIDTypeParameter] = value; }
}
public Int32? IDAUTOTypeParameter{
get {
if(this[this.tabletTypeParameter.cIDAUTOTypeParameter] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletTypeParameter.cIDAUTOTypeParameter])); }
}
        set{
if (value == null){ this[this.tabletTypeParameter.cIDAUTOTypeParameter] = DBNull.Value; }
else{ this[this.tabletTypeParameter.cIDAUTOTypeParameter] = value; }
}
}

        public String vchName{
get { return ((String)(this[this.tabletTypeParameter.cvchName])); }
set{ this[this.tabletTypeParameter.cvchName] = value; }
}
public String descTypeParameter{
get {
if(this[this.tabletTypeParameter.cdescTypeParameter] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletTypeParameter.cdescTypeParameter])); }
}
        set{
if (value == null){ this[this.tabletTypeParameter.cdescTypeParameter] = DBNull.Value; }
else{ this[this.tabletTypeParameter.cdescTypeParameter] = value; }
}
}

        public Boolean bitAcvive{
get { return ((Boolean)(this[this.tabletTypeParameter.cbitAcvive])); }
set{ this[this.tabletTypeParameter.cbitAcvive] = value; }
}


            public Models.tTypeParameter GetModel()
            {
                Models.tTypeParameter model = new Models.tTypeParameter();

                model.IDTypeParameter = this.IDTypeParameter;
                model.IDAUTOTypeParameter = this.IDAUTOTypeParameter;
                model.vchName = this.vchName;
                model.descTypeParameter = this.descTypeParameter;
                model.bitAcvive = this.bitAcvive;
                
                return model;
            }
		}
		#endregion

        #region Constructor and Columns

        public tTypeParameterRow Columns
        {
            get
            {
                return (tTypeParameterRow)this.Current;
            }
        }

		public tTypeParameterTable Table
        {
            get
            {
                return (tTypeParameterTable)this.Data.Tables[this.TableName];
            }
        }

        public tTypeParameter(): base("VoxCRI", "tTypeParameter")
        {
            this.Data.Tables.Add(new tTypeParameterTable());
        }

        public tTypeParameter(Log oLog): base(oLog, "VoxCRI", "tTypeParameter")
        {
            this.Data.Tables.Add(new tTypeParameterTable());
        }

        public IEnumerable<Models.tTypeParameter> GetModels()
        {
            return this.Table.Select(x => x.GetModel());
        }

public override void Validate()
        {
            base.Validate();        
        }

        public void Close()
        {
            base.CloseConnection(this.TableName);
        }

        ~tTypeParameter()
        {
            this.Close(); base.Dispose();
        }

		#endregion

       
    }
}
