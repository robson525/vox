using System;
using System.Data;
using System.Collections.Generic;
using VoxData.Shared.Functions;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tParameter: TTableSQL
    {
		#region DataTable
		[Serializable()]
        public class tParameterTable : TypedTableBase<tParameterRow>
        {
			public DataColumn cIDParameter { get; private set; }
            public DataColumn cIDTypeParameter { get; private set; }
            public DataColumn cvchValue { get; private set; }
            public DataColumn cvchTypeValue { get; private set; }
            

			public tParameterTable()
            {
                this.TableName = "tParameter";
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

			public tParameterRow this[int index]
            {
                get
                {
                    return ((tParameterRow)(this.Rows[index]));
                }
            }

			protected override DataTable CreateInstance()
            {
                return new tParameterTable();
            }

			private void InitClass()
            {
				this.cIDParameter = new DataColumn("IDParameter", typeof(String), null, MappingType.Element);
                this.cIDParameter.AllowDBNull = false;
                this.cIDParameter.ExtendedProperties.Add("Editable", "true");
                this.cIDParameter.ExtendedProperties.Add("PrimaryKey", "true");
                base.Columns.Add(this.cIDParameter);
                this.cIDTypeParameter = new DataColumn("IDTypeParameter", typeof(Int32), null, MappingType.Element);
                this.cIDTypeParameter.AllowDBNull = true;
                this.cIDTypeParameter.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cIDTypeParameter);
                this.cvchValue = new DataColumn("vchValue", typeof(String), null, MappingType.Element);
                this.cvchValue.AllowDBNull = true;
                this.cvchValue.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchValue);
                this.cvchTypeValue = new DataColumn("vchTypeValue", typeof(String), null, MappingType.Element);
                this.cvchTypeValue.AllowDBNull = true;
                this.cvchTypeValue.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchTypeValue);
                
			}

			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new tParameterRow(builder);
            }

            protected override global::System.Type GetRowType()
            {
                return typeof(tParameterRow);
            }

            public tParameterRow NewRow()
            {
                return (tParameterRow)base.NewRow();
            }
		}
		#endregion

		#region DataRow
		[Serializable()]
        public class tParameterRow : DataRow
        {
			private tParameterTable tabletParameter;

			internal tParameterRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletParameter = ((tParameterTable)(this.Table));
            }


			public String IDParameter{
get { return ((String)(this[this.tabletParameter.cIDParameter])); }
set{ this[this.tabletParameter.cIDParameter] = value; }
}
public Int32? IDTypeParameter{
get {
if(this[this.tabletParameter.cIDTypeParameter] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletParameter.cIDTypeParameter])); }
}
        set{
if (value == null){ this[this.tabletParameter.cIDTypeParameter] = DBNull.Value; }
else{ this[this.tabletParameter.cIDTypeParameter] = value; }
}
}

        public String vchValue{
get {
if(this[this.tabletParameter.cvchValue] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletParameter.cvchValue])); }
}
        set{
if (value == null){ this[this.tabletParameter.cvchValue] = DBNull.Value; }
else{ this[this.tabletParameter.cvchValue] = value; }
}
}

        public String vchTypeValue{
get {
if(this[this.tabletParameter.cvchTypeValue] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletParameter.cvchTypeValue])); }
}
        set{
if (value == null){ this[this.tabletParameter.cvchTypeValue] = DBNull.Value; }
else{ this[this.tabletParameter.cvchTypeValue] = value; }
}
}

        

            public Models.tParameter GetModel()
            {
                Models.tParameter model = new Models.tParameter();

                model.IDParameter = this.IDParameter;
                model.IDTypeParameter = this.IDTypeParameter;
                model.vchValue = this.vchValue;
                model.vchTypeValue = this.vchTypeValue;
                
                return model;
            }
		}
		#endregion

        #region Constructor and Columns

        public tParameterRow Columns
        {
            get
            {
                return (tParameterRow)this.Current;
            }
        }

		public tParameterTable Table
        {
            get
            {
                return (tParameterTable)this.Data.Tables[this.TableName];
            }
        }

        public tParameter(): base("VoxCRI", "tParameter")
        {
            this.Data.Tables.Add(new tParameterTable());
        }

        public tParameter(Log oLog): base(oLog, "VoxCRI", "tParameter")
        {
            this.Data.Tables.Add(new tParameterTable());
        }

        public IEnumerable<Models.tParameter> GetModels()
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

        ~tParameter()
        {
            this.Close(); base.Dispose();
        }

		#endregion

       
    }
}
