using System;
using System.Data;
using System.Collections.Generic;
using VoxData.Shared.Functions;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRICatalog: TTableSQL
    {
		#region DataTable
		[Serializable()]
        public class tCRICatalogTable : TypedTableBase<tCRICatalogRow>
        {
			public DataColumn csintObjectId { get; private set; }
            public DataColumn csintIdCl { get; private set; }
            public DataColumn cvchIdMao { get; private set; }
            public DataColumn cchrObjectType { get; private set; }
            public DataColumn cvchMatricule { get; private set; }
            public DataColumn cintCreateDate { get; private set; }
            public DataColumn cintDeleteDate { get; private set; }
            public DataColumn cdtmCreateDate { get; private set; }
            public DataColumn cdtmDeleteDate { get; private set; }
            public DataColumn cdtmLoaded { get; private set; }
            public DataColumn cbitVisible { get; private set; }
            

			public tCRICatalogTable()
            {
                this.TableName = "tCRICatalog";
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

			public tCRICatalogRow this[int index]
            {
                get
                {
                    return ((tCRICatalogRow)(this.Rows[index]));
                }
            }

			protected override DataTable CreateInstance()
            {
                return new tCRICatalogTable();
            }

			private void InitClass()
            {
				this.csintObjectId = new DataColumn("sintObjectId", typeof(Int16), null, MappingType.Element);
                this.csintObjectId.AllowDBNull = false;
                this.csintObjectId.ExtendedProperties.Add("Editable", "true");
                this.csintObjectId.ExtendedProperties.Add("PrimaryKey", "true");
                base.Columns.Add(this.csintObjectId);
                this.csintIdCl = new DataColumn("sintIdCl", typeof(Int16), null, MappingType.Element);
                this.csintIdCl.AllowDBNull = false;
                this.csintIdCl.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintIdCl);
                this.cvchIdMao = new DataColumn("vchIdMao", typeof(String), null, MappingType.Element);
                this.cvchIdMao.AllowDBNull = false;
                this.cvchIdMao.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchIdMao);
                this.cchrObjectType = new DataColumn("chrObjectType", typeof(String), null, MappingType.Element);
                this.cchrObjectType.AllowDBNull = false;
                this.cchrObjectType.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrObjectType);
                this.cvchMatricule = new DataColumn("vchMatricule", typeof(String), null, MappingType.Element);
                this.cvchMatricule.AllowDBNull = false;
                this.cvchMatricule.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchMatricule);
                this.cintCreateDate = new DataColumn("intCreateDate", typeof(Int32), null, MappingType.Element);
                this.cintCreateDate.AllowDBNull = false;
                this.cintCreateDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintCreateDate);
                this.cintDeleteDate = new DataColumn("intDeleteDate", typeof(Int32), null, MappingType.Element);
                this.cintDeleteDate.AllowDBNull = false;
                this.cintDeleteDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintDeleteDate);
                this.cdtmCreateDate = new DataColumn("dtmCreateDate", typeof(DateTime), null, MappingType.Element);
                this.cdtmCreateDate.AllowDBNull = false;
                this.cdtmCreateDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdtmCreateDate);
                this.cdtmDeleteDate = new DataColumn("dtmDeleteDate", typeof(DateTime), null, MappingType.Element);
                this.cdtmDeleteDate.AllowDBNull = true;
                this.cdtmDeleteDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdtmDeleteDate);
                this.cdtmLoaded = new DataColumn("dtmLoaded", typeof(DateTime), null, MappingType.Element);
                this.cdtmLoaded.AllowDBNull = false;
                this.cdtmLoaded.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdtmLoaded);
                this.cbitVisible = new DataColumn("bitVisible", typeof(Boolean), null, MappingType.Element);
                this.cbitVisible.AllowDBNull = false;
                this.cbitVisible.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cbitVisible);
                
			}

			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new tCRICatalogRow(builder);
            }

            protected override global::System.Type GetRowType()
            {
                return typeof(tCRICatalogRow);
            }

            public tCRICatalogRow NewRow()
            {
                return (tCRICatalogRow)base.NewRow();
            }
		}
		#endregion

		#region DataRow
		[Serializable()]
        public class tCRICatalogRow : DataRow
        {
			private tCRICatalogTable tabletCRICatalog;

			internal tCRICatalogRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletCRICatalog = ((tCRICatalogTable)(this.Table));
            }


			public Int16 sintObjectId{
get { return ((Int16)(this[this.tabletCRICatalog.csintObjectId])); }
set{ this[this.tabletCRICatalog.csintObjectId] = value; }
}
public Int16 sintIdCl{
get { return ((Int16)(this[this.tabletCRICatalog.csintIdCl])); }
set{ this[this.tabletCRICatalog.csintIdCl] = value; }
}
public String vchIdMao{
get { return ((String)(this[this.tabletCRICatalog.cvchIdMao])); }
set{ this[this.tabletCRICatalog.cvchIdMao] = value; }
}
public String chrObjectType{
get { return ((String)(this[this.tabletCRICatalog.cchrObjectType])); }
set{ this[this.tabletCRICatalog.cchrObjectType] = value; }
}
public String vchMatricule{
get { return ((String)(this[this.tabletCRICatalog.cvchMatricule])); }
set{ this[this.tabletCRICatalog.cvchMatricule] = value; }
}
public Int32 intCreateDate{
get { return ((Int32)(this[this.tabletCRICatalog.cintCreateDate])); }
set{ this[this.tabletCRICatalog.cintCreateDate] = value; }
}
public Int32 intDeleteDate{
get { return ((Int32)(this[this.tabletCRICatalog.cintDeleteDate])); }
set{ this[this.tabletCRICatalog.cintDeleteDate] = value; }
}
public DateTime dtmCreateDate{
get { return ((DateTime)(this[this.tabletCRICatalog.cdtmCreateDate])); }
set{ this[this.tabletCRICatalog.cdtmCreateDate] = value; }
}
public DateTime? dtmDeleteDate{
get {
if(this[this.tabletCRICatalog.cdtmDeleteDate] == DBNull.Value){ return null; }
else{ return ((DateTime)(this[this.tabletCRICatalog.cdtmDeleteDate])); }
}
        set{
if (value == null){ this[this.tabletCRICatalog.cdtmDeleteDate] = DBNull.Value; }
else{ this[this.tabletCRICatalog.cdtmDeleteDate] = value; }
}
}

        public DateTime dtmLoaded{
get { return ((DateTime)(this[this.tabletCRICatalog.cdtmLoaded])); }
set{ this[this.tabletCRICatalog.cdtmLoaded] = value; }
}
public Boolean bitVisible{
get { return ((Boolean)(this[this.tabletCRICatalog.cbitVisible])); }
set{ this[this.tabletCRICatalog.cbitVisible] = value; }
}


            public Models.tCRICatalog GetModel()
            {
                Models.tCRICatalog model = new Models.tCRICatalog();

                model.sintObjectId = this.sintObjectId;
                model.sintIdCl = this.sintIdCl;
                model.vchIdMao = this.vchIdMao;
                model.chrObjectType = this.chrObjectType;
                model.vchMatricule = this.vchMatricule;
                model.intCreateDate = this.intCreateDate;
                model.intDeleteDate = this.intDeleteDate;
                model.dtmCreateDate = this.dtmCreateDate;
                model.dtmDeleteDate = this.dtmDeleteDate;
                model.dtmLoaded = this.dtmLoaded;
                model.bitVisible = this.bitVisible;
                
                return model;
            }
		}
		#endregion

        #region Constructor and Columns

        public tCRICatalogRow Columns
        {
            get
            {
                return (tCRICatalogRow)this.Current;
            }
        }

		public tCRICatalogTable Table
        {
            get
            {
                return (tCRICatalogTable)this.Data.Tables[this.TableName];
            }
        }

        public tCRICatalog(): base("VoxCRI", "tCRICatalog")
        {
            this.Data.Tables.Add(new tCRICatalogTable());
        }

        public tCRICatalog(Log oLog): base(oLog, "VoxCRI", "tCRICatalog")
        {
            this.Data.Tables.Add(new tCRICatalogTable());
        }

        public IEnumerable<Models.tCRICatalog> GetModels()
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

        ~tCRICatalog()
        {
            this.Close(); base.Dispose();
        }

		#endregion

       
    }
}
