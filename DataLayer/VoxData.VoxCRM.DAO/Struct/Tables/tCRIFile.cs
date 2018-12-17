using System;
using System.Data;
using System.Collections.Generic;
using VoxData.Shared.Functions;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRIFile: TTableSQL
    {
		#region DataTable
		[Serializable()]
        public class tCRIFileTable : TypedTableBase<tCRIFileRow>
        {
			public DataColumn cIDCRIFile { get; private set; }
            public DataColumn cvchFileName { get; private set; }
            public DataColumn cdtmDateFile { get; private set; }
            public DataColumn cbitClosed { get; private set; }
            public DataColumn cintPointer { get; private set; }
            public DataColumn cintErrors { get; private set; }
            public DataColumn cvchType { get; private set; }
            

			public tCRIFileTable()
            {
                this.TableName = "tCRIFile";
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

			public tCRIFileRow this[int index]
            {
                get
                {
                    return ((tCRIFileRow)(this.Rows[index]));
                }
            }

			protected override DataTable CreateInstance()
            {
                return new tCRIFileTable();
            }

			private void InitClass()
            {
				this.cIDCRIFile = new DataColumn("IDCRIFile", typeof(Int64), null, MappingType.Element);
                this.cIDCRIFile.AllowDBNull = false;
                this.cIDCRIFile.AutoIncrement = true;
                this.cIDCRIFile.AutoIncrementSeed = -1;
                this.cIDCRIFile.AutoIncrementStep = -1;
                this.cIDCRIFile.ExtendedProperties.Add("PrimaryKey", "true");
                base.Columns.Add(this.cIDCRIFile);
                this.cvchFileName = new DataColumn("vchFileName", typeof(String), null, MappingType.Element);
                this.cvchFileName.AllowDBNull = false;
                this.cvchFileName.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchFileName);
                this.cdtmDateFile = new DataColumn("dtmDateFile", typeof(DateTime), null, MappingType.Element);
                this.cdtmDateFile.AllowDBNull = false;
                this.cdtmDateFile.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdtmDateFile);
                this.cbitClosed = new DataColumn("bitClosed", typeof(Boolean), null, MappingType.Element);
                this.cbitClosed.AllowDBNull = false;
                this.cbitClosed.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cbitClosed);
                this.cintPointer = new DataColumn("intPointer", typeof(Int32), null, MappingType.Element);
                this.cintPointer.AllowDBNull = false;
                this.cintPointer.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintPointer);
                this.cintErrors = new DataColumn("intErrors", typeof(Int32), null, MappingType.Element);
                this.cintErrors.AllowDBNull = false;
                this.cintErrors.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintErrors);
                this.cvchType = new DataColumn("vchType", typeof(String), null, MappingType.Element);
                this.cvchType.AllowDBNull = false;
                this.cvchType.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchType);
                
			}

			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new tCRIFileRow(builder);
            }

            protected override global::System.Type GetRowType()
            {
                return typeof(tCRIFileRow);
            }

            public tCRIFileRow NewRow()
            {
                return (tCRIFileRow)base.NewRow();
            }
		}
		#endregion

		#region DataRow
		[Serializable()]
        public class tCRIFileRow : DataRow
        {
			private tCRIFileTable tabletCRIFile;

			internal tCRIFileRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletCRIFile = ((tCRIFileTable)(this.Table));
            }


			public Int64 IDCRIFile{
get { return ((Int64)(this[this.tabletCRIFile.cIDCRIFile])); }
set{ this[this.tabletCRIFile.cIDCRIFile] = value; }
}
public String vchFileName{
get { return ((String)(this[this.tabletCRIFile.cvchFileName])); }
set{ this[this.tabletCRIFile.cvchFileName] = value; }
}
public DateTime dtmDateFile{
get { return ((DateTime)(this[this.tabletCRIFile.cdtmDateFile])); }
set{ this[this.tabletCRIFile.cdtmDateFile] = value; }
}
public Boolean bitClosed{
get { return ((Boolean)(this[this.tabletCRIFile.cbitClosed])); }
set{ this[this.tabletCRIFile.cbitClosed] = value; }
}
public Int32 intPointer{
get { return ((Int32)(this[this.tabletCRIFile.cintPointer])); }
set{ this[this.tabletCRIFile.cintPointer] = value; }
}
public Int32 intErrors{
get { return ((Int32)(this[this.tabletCRIFile.cintErrors])); }
set{ this[this.tabletCRIFile.cintErrors] = value; }
}
public String vchType{
get { return ((String)(this[this.tabletCRIFile.cvchType])); }
set{ this[this.tabletCRIFile.cvchType] = value; }
}


            public Models.tCRIFile GetModel()
            {
                Models.tCRIFile model = new Models.tCRIFile();

                model.IDCRIFile = this.IDCRIFile;
                model.vchFileName = this.vchFileName;
                model.dtmDateFile = this.dtmDateFile;
                model.bitClosed = this.bitClosed;
                model.intPointer = this.intPointer;
                model.intErrors = this.intErrors;
                model.vchType = this.vchType;
                
                return model;
            }
		}
		#endregion

        #region Constructor and Columns

        public tCRIFileRow Columns
        {
            get
            {
                return (tCRIFileRow)this.Current;
            }
        }

		public tCRIFileTable Table
        {
            get
            {
                return (tCRIFileTable)this.Data.Tables[this.TableName];
            }
        }

        public tCRIFile(): base("VoxCRI", "tCRIFile")
        {
            this.Data.Tables.Add(new tCRIFileTable());
        }

        public tCRIFile(Log oLog): base(oLog, "VoxCRI", "tCRIFile")
        {
            this.Data.Tables.Add(new tCRIFileTable());
        }

        public IEnumerable<Models.tCRIFile> GetModels()
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

        ~tCRIFile()
        {
            this.Close(); base.Dispose();
        }

		#endregion

       
    }
}
