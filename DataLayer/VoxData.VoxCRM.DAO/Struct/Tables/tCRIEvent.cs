using System;
using System.Data;
using System.Collections.Generic;
using VoxData.Shared.Functions;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRIEvent: TTableSQL
    {
		#region DataTable
		[Serializable()]
        public class tCRIEventTable : TypedTableBase<tCRIEventRow>
        {
			public DataColumn cIDCRIEvent { get; private set; }
            public DataColumn cIDCRIFile { get; private set; }
            public DataColumn cintDateTicket { get; private set; }
            public DataColumn csintObjectId { get; private set; }
            public DataColumn cintDate { get; private set; }
            public DataColumn cchrState { get; private set; }
            public DataColumn cchrInfo { get; private set; }
            public DataColumn csintTeam { get; private set; }
            public DataColumn cdtmLoaded { get; private set; }
            

			public tCRIEventTable()
            {
                this.TableName = "tCRIEvent";
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

			public tCRIEventRow this[int index]
            {
                get
                {
                    return ((tCRIEventRow)(this.Rows[index]));
                }
            }

			protected override DataTable CreateInstance()
            {
                return new tCRIEventTable();
            }

			private void InitClass()
            {
				this.cIDCRIEvent = new DataColumn("IDCRIEvent", typeof(Int64), null, MappingType.Element);
                this.cIDCRIEvent.AllowDBNull = false;
                this.cIDCRIEvent.AutoIncrement = true;
                this.cIDCRIEvent.AutoIncrementSeed = -1;
                this.cIDCRIEvent.AutoIncrementStep = -1;
                this.cIDCRIEvent.ExtendedProperties.Add("PrimaryKey", "true");
                base.Columns.Add(this.cIDCRIEvent);
                this.cIDCRIFile = new DataColumn("IDCRIFile", typeof(Int64), null, MappingType.Element);
                this.cIDCRIFile.AllowDBNull = false;
                this.cIDCRIFile.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cIDCRIFile);
                this.cintDateTicket = new DataColumn("intDateTicket", typeof(Int32), null, MappingType.Element);
                this.cintDateTicket.AllowDBNull = true;
                this.cintDateTicket.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintDateTicket);
                this.csintObjectId = new DataColumn("sintObjectId", typeof(Int16), null, MappingType.Element);
                this.csintObjectId.AllowDBNull = true;
                this.csintObjectId.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintObjectId);
                this.cintDate = new DataColumn("intDate", typeof(Int32), null, MappingType.Element);
                this.cintDate.AllowDBNull = true;
                this.cintDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintDate);
                this.cchrState = new DataColumn("chrState", typeof(String), null, MappingType.Element);
                this.cchrState.AllowDBNull = true;
                this.cchrState.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrState);
                this.cchrInfo = new DataColumn("chrInfo", typeof(String), null, MappingType.Element);
                this.cchrInfo.AllowDBNull = true;
                this.cchrInfo.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrInfo);
                this.csintTeam = new DataColumn("sintTeam", typeof(Int16), null, MappingType.Element);
                this.csintTeam.AllowDBNull = true;
                this.csintTeam.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintTeam);
                this.cdtmLoaded = new DataColumn("dtmLoaded", typeof(DateTime), null, MappingType.Element);
                this.cdtmLoaded.AllowDBNull = true;
                this.cdtmLoaded.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdtmLoaded);
                
			}

			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new tCRIEventRow(builder);
            }

            protected override global::System.Type GetRowType()
            {
                return typeof(tCRIEventRow);
            }

            public tCRIEventRow NewRow()
            {
                return (tCRIEventRow)base.NewRow();
            }
		}
		#endregion

		#region DataRow
		[Serializable()]
        public class tCRIEventRow : DataRow
        {
			private tCRIEventTable tabletCRIEvent;

			internal tCRIEventRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletCRIEvent = ((tCRIEventTable)(this.Table));
            }


			public Int64 IDCRIEvent{
get { return ((Int64)(this[this.tabletCRIEvent.cIDCRIEvent])); }
set{ this[this.tabletCRIEvent.cIDCRIEvent] = value; }
}
public Int64 IDCRIFile{
get { return ((Int64)(this[this.tabletCRIEvent.cIDCRIFile])); }
set{ this[this.tabletCRIEvent.cIDCRIFile] = value; }
}
public Int32? intDateTicket{
get {
if(this[this.tabletCRIEvent.cintDateTicket] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRIEvent.cintDateTicket])); }
}
        set{
if (value == null){ this[this.tabletCRIEvent.cintDateTicket] = DBNull.Value; }
else{ this[this.tabletCRIEvent.cintDateTicket] = value; }
}
}

        public Int16? sintObjectId{
get {
if(this[this.tabletCRIEvent.csintObjectId] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRIEvent.csintObjectId])); }
}
        set{
if (value == null){ this[this.tabletCRIEvent.csintObjectId] = DBNull.Value; }
else{ this[this.tabletCRIEvent.csintObjectId] = value; }
}
}

        public Int32? intDate{
get {
if(this[this.tabletCRIEvent.cintDate] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRIEvent.cintDate])); }
}
        set{
if (value == null){ this[this.tabletCRIEvent.cintDate] = DBNull.Value; }
else{ this[this.tabletCRIEvent.cintDate] = value; }
}
}

        public String chrState{
get {
if(this[this.tabletCRIEvent.cchrState] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRIEvent.cchrState])); }
}
        set{
if (value == null){ this[this.tabletCRIEvent.cchrState] = DBNull.Value; }
else{ this[this.tabletCRIEvent.cchrState] = value; }
}
}

        public String chrInfo{
get {
if(this[this.tabletCRIEvent.cchrInfo] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRIEvent.cchrInfo])); }
}
        set{
if (value == null){ this[this.tabletCRIEvent.cchrInfo] = DBNull.Value; }
else{ this[this.tabletCRIEvent.cchrInfo] = value; }
}
}

        public Int16? sintTeam{
get {
if(this[this.tabletCRIEvent.csintTeam] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRIEvent.csintTeam])); }
}
        set{
if (value == null){ this[this.tabletCRIEvent.csintTeam] = DBNull.Value; }
else{ this[this.tabletCRIEvent.csintTeam] = value; }
}
}

        public DateTime? dtmLoaded{
get {
if(this[this.tabletCRIEvent.cdtmLoaded] == DBNull.Value){ return null; }
else{ return ((DateTime)(this[this.tabletCRIEvent.cdtmLoaded])); }
}
        set{
if (value == null){ this[this.tabletCRIEvent.cdtmLoaded] = DBNull.Value; }
else{ this[this.tabletCRIEvent.cdtmLoaded] = value; }
}
}

        

            public Models.tCRIEvent GetModel()
            {
                Models.tCRIEvent model = new Models.tCRIEvent();

                model.IDCRIEvent = this.IDCRIEvent;
                model.IDCRIFile = this.IDCRIFile;
                model.intDateTicket = this.intDateTicket;
                model.sintObjectId = this.sintObjectId;
                model.intDate = this.intDate;
                model.chrState = this.chrState;
                model.chrInfo = this.chrInfo;
                model.sintTeam = this.sintTeam;
                model.dtmLoaded = this.dtmLoaded;
                
                return model;
            }
		}
		#endregion

        #region Constructor and Columns

        public tCRIEventRow Columns
        {
            get
            {
                return (tCRIEventRow)this.Current;
            }
        }

		public tCRIEventTable Table
        {
            get
            {
                return (tCRIEventTable)this.Data.Tables[this.TableName];
            }
        }

        public tCRIEvent(): base("VoxCRI", "tCRIEvent")
        {
            this.Data.Tables.Add(new tCRIEventTable());
        }

        public tCRIEvent(Log oLog): base(oLog, "VoxCRI", "tCRIEvent")
        {
            this.Data.Tables.Add(new tCRIEventTable());
        }

        public IEnumerable<Models.tCRIEvent> GetModels()
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

        ~tCRIEvent()
        {
            this.Close(); base.Dispose();
        }

		#endregion

       
    }
}
