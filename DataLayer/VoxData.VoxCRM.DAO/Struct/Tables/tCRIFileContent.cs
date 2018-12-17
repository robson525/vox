using System;
using System.Data;
using System.Collections.Generic;
using VoxData.Shared.Functions;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRIFileContent: TTableSQL
    {
		#region DataTable
		[Serializable()]
        public class tCRIFileContentTable : TypedTableBase<tCRIFileContentRow>
        {
			public DataColumn cIDCRIFileContent { get; private set; }
            public DataColumn cIDCRIFile { get; private set; }
            public DataColumn cdtmLoaded { get; private set; }
            public DataColumn cintVersion { get; private set; }
            public DataColumn cintLength { get; private set; }
            public DataColumn cintRead { get; private set; }
            

			public tCRIFileContentTable()
            {
                this.TableName = "tCRIFileContent";
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

			public tCRIFileContentRow this[int index]
            {
                get
                {
                    return ((tCRIFileContentRow)(this.Rows[index]));
                }
            }

			protected override DataTable CreateInstance()
            {
                return new tCRIFileContentTable();
            }

			private void InitClass()
            {
				this.cIDCRIFileContent = new DataColumn("IDCRIFileContent", typeof(Int64), null, MappingType.Element);
                this.cIDCRIFileContent.AllowDBNull = false;
                this.cIDCRIFileContent.AutoIncrement = true;
                this.cIDCRIFileContent.AutoIncrementSeed = -1;
                this.cIDCRIFileContent.AutoIncrementStep = -1;
                this.cIDCRIFileContent.ExtendedProperties.Add("PrimaryKey", "true");
                base.Columns.Add(this.cIDCRIFileContent);
                this.cIDCRIFile = new DataColumn("IDCRIFile", typeof(Int64), null, MappingType.Element);
                this.cIDCRIFile.AllowDBNull = false;
                this.cIDCRIFile.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cIDCRIFile);
                this.cdtmLoaded = new DataColumn("dtmLoaded", typeof(DateTime), null, MappingType.Element);
                this.cdtmLoaded.AllowDBNull = false;
                this.cdtmLoaded.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdtmLoaded);
                this.cintVersion = new DataColumn("intVersion", typeof(Int32), null, MappingType.Element);
                this.cintVersion.AllowDBNull = false;
                this.cintVersion.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintVersion);
                this.cintLength = new DataColumn("intLength", typeof(Int32), null, MappingType.Element);
                this.cintLength.AllowDBNull = false;
                this.cintLength.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintLength);
                this.cintRead = new DataColumn("intRead", typeof(Int32), null, MappingType.Element);
                this.cintRead.AllowDBNull = false;
                this.cintRead.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintRead);
                
			}

			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new tCRIFileContentRow(builder);
            }

            protected override global::System.Type GetRowType()
            {
                return typeof(tCRIFileContentRow);
            }

            public tCRIFileContentRow NewRow()
            {
                return (tCRIFileContentRow)base.NewRow();
            }
		}
		#endregion

		#region DataRow
		[Serializable()]
        public class tCRIFileContentRow : DataRow
        {
			private tCRIFileContentTable tabletCRIFileContent;

			internal tCRIFileContentRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletCRIFileContent = ((tCRIFileContentTable)(this.Table));
            }


			public Int64 IDCRIFileContent{
get { return ((Int64)(this[this.tabletCRIFileContent.cIDCRIFileContent])); }
set{ this[this.tabletCRIFileContent.cIDCRIFileContent] = value; }
}
public Int64 IDCRIFile{
get { return ((Int64)(this[this.tabletCRIFileContent.cIDCRIFile])); }
set{ this[this.tabletCRIFileContent.cIDCRIFile] = value; }
}
public DateTime dtmLoaded{
get { return ((DateTime)(this[this.tabletCRIFileContent.cdtmLoaded])); }
set{ this[this.tabletCRIFileContent.cdtmLoaded] = value; }
}
public Int32 intVersion{
get { return ((Int32)(this[this.tabletCRIFileContent.cintVersion])); }
set{ this[this.tabletCRIFileContent.cintVersion] = value; }
}
public Int32 intLength{
get { return ((Int32)(this[this.tabletCRIFileContent.cintLength])); }
set{ this[this.tabletCRIFileContent.cintLength] = value; }
}
public Int32 intRead{
get { return ((Int32)(this[this.tabletCRIFileContent.cintRead])); }
set{ this[this.tabletCRIFileContent.cintRead] = value; }
}


            public Models.tCRIFileContent GetModel()
            {
                Models.tCRIFileContent model = new Models.tCRIFileContent();

                model.IDCRIFileContent = this.IDCRIFileContent;
                model.IDCRIFile = this.IDCRIFile;
                model.dtmLoaded = this.dtmLoaded;
                model.intVersion = this.intVersion;
                model.intLength = this.intLength;
                model.intRead = this.intRead;
                
                return model;
            }
		}
		#endregion

        #region Constructor and Columns

        public tCRIFileContentRow Columns
        {
            get
            {
                return (tCRIFileContentRow)this.Current;
            }
        }

		public tCRIFileContentTable Table
        {
            get
            {
                return (tCRIFileContentTable)this.Data.Tables[this.TableName];
            }
        }

        public tCRIFileContent(): base("VoxCRI", "tCRIFileContent")
        {
            this.Data.Tables.Add(new tCRIFileContentTable());
        }

        public tCRIFileContent(Log oLog): base(oLog, "VoxCRI", "tCRIFileContent")
        {
            this.Data.Tables.Add(new tCRIFileContentTable());
        }

        public IEnumerable<Models.tCRIFileContent> GetModels()
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

        ~tCRIFileContent()
        {
            this.Close(); base.Dispose();
        }

		#endregion

       
    }
}
