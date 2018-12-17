using System;
using System.Data;
using System.Collections.Generic;
using VoxData.Shared.Functions;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRICommunication: TTableSQL
    {
		#region DataTable
		[Serializable()]
        public class tCRICommunicationTable : TypedTableBase<tCRICommunicationRow>
        {
			public DataColumn cIDCRICommunication { get; private set; }
            public DataColumn cIDCRIFile { get; private set; }
            public DataColumn cintTicketRef { get; private set; }
            public DataColumn cintParentTicketRef { get; private set; }
            public DataColumn cintChildTicketRef { get; private set; }
            public DataColumn cintBeginningDate { get; private set; }
            public DataColumn cintEndDate { get; private set; }
            public DataColumn csintTrunkGroup { get; private set; }
            public DataColumn csintPilotNumber { get; private set; }
            public DataColumn csintReceptionGroup { get; private set; }
            public DataColumn csintProcessingGroup { get; private set; }
            public DataColumn csintDestAgent { get; private set; }
            public DataColumn csintAnsweringAgent { get; private set; }
            public DataColumn csintPreviousWaitingTime { get; private set; }
            public DataColumn csintWaitingTime { get; private set; }
            public DataColumn csintIvrWaitingTime { get; private set; }
            public DataColumn csintRingingTime1 { get; private set; }
            public DataColumn csintRingingTime2 { get; private set; }
            public DataColumn csintTalkingTime { get; private set; }
            public DataColumn csintCallOnHoldTime { get; private set; }
            public DataColumn csintEnquiryDest1 { get; private set; }
            public DataColumn csintEnquiryTime1 { get; private set; }
            public DataColumn csintEnquiryDest2 { get; private set; }
            public DataColumn csintEnquiryTime2 { get; private set; }
            public DataColumn csintEnquiryDest3 { get; private set; }
            public DataColumn csintEnquiryTime3 { get; private set; }
            public DataColumn csintTransferDest { get; private set; }
            public DataColumn csintTransactionTime { get; private set; }
            public DataColumn cvchTransactionCode { get; private set; }
            public DataColumn cchrIntroGuideTime { get; private set; }
            public DataColumn csintIdPilotStat { get; private set; }
            public DataColumn cintCommReleaseDate { get; private set; }
            public DataColumn csintWrapUpTime { get; private set; }
            public DataColumn csintWrapUpActivationNumber { get; private set; }
            public DataColumn csintPauseTime { get; private set; }
            public DataColumn csintHelp { get; private set; }
            public DataColumn csintVoiceGuideType { get; private set; }
            public DataColumn cchrPilotState { get; private set; }
            public DataColumn cchrRecByMutualAid { get; private set; }
            public DataColumn cvchNDS { get; private set; }
            public DataColumn cvchInitialNumberCalled { get; private set; }
            public DataColumn ctintCreatCause { get; private set; }
            public DataColumn ctintEndCause { get; private set; }
            public DataColumn csintRecordTime { get; private set; }
            public DataColumn cintIVRTicketRef { get; private set; }
            public DataColumn cvchCorrelatorData { get; private set; }
            public DataColumn csintSkill1 { get; private set; }
            public DataColumn csintSkill2 { get; private set; }
            public DataColumn csintSkill3 { get; private set; }
            public DataColumn csintSkill4 { get; private set; }
            public DataColumn csintSkill5 { get; private set; }
            public DataColumn csintSkill6 { get; private set; }
            public DataColumn csintSkill7 { get; private set; }
            public DataColumn cchrExpert { get; private set; }
            public DataColumn cchrCallType { get; private set; }
            public DataColumn csintWLNumber { get; private set; }
            public DataColumn cintDistribMode { get; private set; }
            public DataColumn csintBLNumber { get; private set; }
            public DataColumn csintIdIsm { get; private set; }
            public DataColumn csintKeylcadc { get; private set; }
            public DataColumn csintEmailTime { get; private set; }
            public DataColumn cintGlobalCallId1 { get; private set; }
            public DataColumn cintGlobalCallId2 { get; private set; }
            public DataColumn cdtmPeriod { get; private set; }
            

			public tCRICommunicationTable()
            {
                this.TableName = "tCRICommunication";
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

			public tCRICommunicationRow this[int index]
            {
                get
                {
                    return ((tCRICommunicationRow)(this.Rows[index]));
                }
            }

			protected override DataTable CreateInstance()
            {
                return new tCRICommunicationTable();
            }

			private void InitClass()
            {
				this.cIDCRICommunication = new DataColumn("IDCRICommunication", typeof(Int64), null, MappingType.Element);
                this.cIDCRICommunication.AllowDBNull = false;
                this.cIDCRICommunication.AutoIncrement = true;
                this.cIDCRICommunication.AutoIncrementSeed = -1;
                this.cIDCRICommunication.AutoIncrementStep = -1;
                this.cIDCRICommunication.ExtendedProperties.Add("PrimaryKey", "true");
                base.Columns.Add(this.cIDCRICommunication);
                this.cIDCRIFile = new DataColumn("IDCRIFile", typeof(Int64), null, MappingType.Element);
                this.cIDCRIFile.AllowDBNull = false;
                this.cIDCRIFile.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cIDCRIFile);
                this.cintTicketRef = new DataColumn("intTicketRef", typeof(Int32), null, MappingType.Element);
                this.cintTicketRef.AllowDBNull = true;
                this.cintTicketRef.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintTicketRef);
                this.cintParentTicketRef = new DataColumn("intParentTicketRef", typeof(Int32), null, MappingType.Element);
                this.cintParentTicketRef.AllowDBNull = true;
                this.cintParentTicketRef.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintParentTicketRef);
                this.cintChildTicketRef = new DataColumn("intChildTicketRef", typeof(Int32), null, MappingType.Element);
                this.cintChildTicketRef.AllowDBNull = true;
                this.cintChildTicketRef.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintChildTicketRef);
                this.cintBeginningDate = new DataColumn("intBeginningDate", typeof(Int32), null, MappingType.Element);
                this.cintBeginningDate.AllowDBNull = true;
                this.cintBeginningDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintBeginningDate);
                this.cintEndDate = new DataColumn("intEndDate", typeof(Int32), null, MappingType.Element);
                this.cintEndDate.AllowDBNull = true;
                this.cintEndDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintEndDate);
                this.csintTrunkGroup = new DataColumn("sintTrunkGroup", typeof(Int16), null, MappingType.Element);
                this.csintTrunkGroup.AllowDBNull = true;
                this.csintTrunkGroup.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintTrunkGroup);
                this.csintPilotNumber = new DataColumn("sintPilotNumber", typeof(Int16), null, MappingType.Element);
                this.csintPilotNumber.AllowDBNull = true;
                this.csintPilotNumber.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintPilotNumber);
                this.csintReceptionGroup = new DataColumn("sintReceptionGroup", typeof(Int16), null, MappingType.Element);
                this.csintReceptionGroup.AllowDBNull = true;
                this.csintReceptionGroup.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintReceptionGroup);
                this.csintProcessingGroup = new DataColumn("sintProcessingGroup", typeof(Int16), null, MappingType.Element);
                this.csintProcessingGroup.AllowDBNull = true;
                this.csintProcessingGroup.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintProcessingGroup);
                this.csintDestAgent = new DataColumn("sintDestAgent", typeof(Int16), null, MappingType.Element);
                this.csintDestAgent.AllowDBNull = true;
                this.csintDestAgent.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintDestAgent);
                this.csintAnsweringAgent = new DataColumn("sintAnsweringAgent", typeof(Int16), null, MappingType.Element);
                this.csintAnsweringAgent.AllowDBNull = true;
                this.csintAnsweringAgent.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintAnsweringAgent);
                this.csintPreviousWaitingTime = new DataColumn("sintPreviousWaitingTime", typeof(Int16), null, MappingType.Element);
                this.csintPreviousWaitingTime.AllowDBNull = true;
                this.csintPreviousWaitingTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintPreviousWaitingTime);
                this.csintWaitingTime = new DataColumn("sintWaitingTime", typeof(Int16), null, MappingType.Element);
                this.csintWaitingTime.AllowDBNull = true;
                this.csintWaitingTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintWaitingTime);
                this.csintIvrWaitingTime = new DataColumn("sintIvrWaitingTime", typeof(Int16), null, MappingType.Element);
                this.csintIvrWaitingTime.AllowDBNull = true;
                this.csintIvrWaitingTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintIvrWaitingTime);
                this.csintRingingTime1 = new DataColumn("sintRingingTime1", typeof(Int16), null, MappingType.Element);
                this.csintRingingTime1.AllowDBNull = true;
                this.csintRingingTime1.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintRingingTime1);
                this.csintRingingTime2 = new DataColumn("sintRingingTime2", typeof(Int16), null, MappingType.Element);
                this.csintRingingTime2.AllowDBNull = true;
                this.csintRingingTime2.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintRingingTime2);
                this.csintTalkingTime = new DataColumn("sintTalkingTime", typeof(Int16), null, MappingType.Element);
                this.csintTalkingTime.AllowDBNull = true;
                this.csintTalkingTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintTalkingTime);
                this.csintCallOnHoldTime = new DataColumn("sintCallOnHoldTime", typeof(Int16), null, MappingType.Element);
                this.csintCallOnHoldTime.AllowDBNull = true;
                this.csintCallOnHoldTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintCallOnHoldTime);
                this.csintEnquiryDest1 = new DataColumn("sintEnquiryDest1", typeof(Int16), null, MappingType.Element);
                this.csintEnquiryDest1.AllowDBNull = true;
                this.csintEnquiryDest1.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintEnquiryDest1);
                this.csintEnquiryTime1 = new DataColumn("sintEnquiryTime1", typeof(Int16), null, MappingType.Element);
                this.csintEnquiryTime1.AllowDBNull = true;
                this.csintEnquiryTime1.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintEnquiryTime1);
                this.csintEnquiryDest2 = new DataColumn("sintEnquiryDest2", typeof(Int16), null, MappingType.Element);
                this.csintEnquiryDest2.AllowDBNull = true;
                this.csintEnquiryDest2.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintEnquiryDest2);
                this.csintEnquiryTime2 = new DataColumn("sintEnquiryTime2", typeof(Int16), null, MappingType.Element);
                this.csintEnquiryTime2.AllowDBNull = true;
                this.csintEnquiryTime2.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintEnquiryTime2);
                this.csintEnquiryDest3 = new DataColumn("sintEnquiryDest3", typeof(Int16), null, MappingType.Element);
                this.csintEnquiryDest3.AllowDBNull = true;
                this.csintEnquiryDest3.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintEnquiryDest3);
                this.csintEnquiryTime3 = new DataColumn("sintEnquiryTime3", typeof(Int16), null, MappingType.Element);
                this.csintEnquiryTime3.AllowDBNull = true;
                this.csintEnquiryTime3.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintEnquiryTime3);
                this.csintTransferDest = new DataColumn("sintTransferDest", typeof(Int16), null, MappingType.Element);
                this.csintTransferDest.AllowDBNull = true;
                this.csintTransferDest.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintTransferDest);
                this.csintTransactionTime = new DataColumn("sintTransactionTime", typeof(Int16), null, MappingType.Element);
                this.csintTransactionTime.AllowDBNull = true;
                this.csintTransactionTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintTransactionTime);
                this.cvchTransactionCode = new DataColumn("vchTransactionCode", typeof(String), null, MappingType.Element);
                this.cvchTransactionCode.AllowDBNull = true;
                this.cvchTransactionCode.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchTransactionCode);
                this.cchrIntroGuideTime = new DataColumn("chrIntroGuideTime", typeof(String), null, MappingType.Element);
                this.cchrIntroGuideTime.AllowDBNull = true;
                this.cchrIntroGuideTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrIntroGuideTime);
                this.csintIdPilotStat = new DataColumn("sintIdPilotStat", typeof(Int16), null, MappingType.Element);
                this.csintIdPilotStat.AllowDBNull = true;
                this.csintIdPilotStat.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintIdPilotStat);
                this.cintCommReleaseDate = new DataColumn("intCommReleaseDate", typeof(Int32), null, MappingType.Element);
                this.cintCommReleaseDate.AllowDBNull = true;
                this.cintCommReleaseDate.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintCommReleaseDate);
                this.csintWrapUpTime = new DataColumn("sintWrapUpTime", typeof(Int16), null, MappingType.Element);
                this.csintWrapUpTime.AllowDBNull = true;
                this.csintWrapUpTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintWrapUpTime);
                this.csintWrapUpActivationNumber = new DataColumn("sintWrapUpActivationNumber", typeof(Int16), null, MappingType.Element);
                this.csintWrapUpActivationNumber.AllowDBNull = true;
                this.csintWrapUpActivationNumber.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintWrapUpActivationNumber);
                this.csintPauseTime = new DataColumn("sintPauseTime", typeof(Int16), null, MappingType.Element);
                this.csintPauseTime.AllowDBNull = true;
                this.csintPauseTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintPauseTime);
                this.csintHelp = new DataColumn("sintHelp", typeof(Int16), null, MappingType.Element);
                this.csintHelp.AllowDBNull = true;
                this.csintHelp.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintHelp);
                this.csintVoiceGuideType = new DataColumn("sintVoiceGuideType", typeof(Int16), null, MappingType.Element);
                this.csintVoiceGuideType.AllowDBNull = true;
                this.csintVoiceGuideType.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintVoiceGuideType);
                this.cchrPilotState = new DataColumn("chrPilotState", typeof(String), null, MappingType.Element);
                this.cchrPilotState.AllowDBNull = true;
                this.cchrPilotState.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrPilotState);
                this.cchrRecByMutualAid = new DataColumn("chrRecByMutualAid", typeof(String), null, MappingType.Element);
                this.cchrRecByMutualAid.AllowDBNull = true;
                this.cchrRecByMutualAid.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrRecByMutualAid);
                this.cvchNDS = new DataColumn("vchNDS", typeof(String), null, MappingType.Element);
                this.cvchNDS.AllowDBNull = true;
                this.cvchNDS.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchNDS);
                this.cvchInitialNumberCalled = new DataColumn("vchInitialNumberCalled", typeof(String), null, MappingType.Element);
                this.cvchInitialNumberCalled.AllowDBNull = true;
                this.cvchInitialNumberCalled.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchInitialNumberCalled);
                this.ctintCreatCause = new DataColumn("tintCreatCause", typeof(Byte), null, MappingType.Element);
                this.ctintCreatCause.AllowDBNull = true;
                this.ctintCreatCause.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.ctintCreatCause);
                this.ctintEndCause = new DataColumn("tintEndCause", typeof(Byte), null, MappingType.Element);
                this.ctintEndCause.AllowDBNull = true;
                this.ctintEndCause.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.ctintEndCause);
                this.csintRecordTime = new DataColumn("sintRecordTime", typeof(Int16), null, MappingType.Element);
                this.csintRecordTime.AllowDBNull = true;
                this.csintRecordTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintRecordTime);
                this.cintIVRTicketRef = new DataColumn("intIVRTicketRef", typeof(Int32), null, MappingType.Element);
                this.cintIVRTicketRef.AllowDBNull = true;
                this.cintIVRTicketRef.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintIVRTicketRef);
                this.cvchCorrelatorData = new DataColumn("vchCorrelatorData", typeof(String), null, MappingType.Element);
                this.cvchCorrelatorData.AllowDBNull = true;
                this.cvchCorrelatorData.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cvchCorrelatorData);
                this.csintSkill1 = new DataColumn("sintSkill1", typeof(Int16), null, MappingType.Element);
                this.csintSkill1.AllowDBNull = true;
                this.csintSkill1.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintSkill1);
                this.csintSkill2 = new DataColumn("sintSkill2", typeof(Int16), null, MappingType.Element);
                this.csintSkill2.AllowDBNull = true;
                this.csintSkill2.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintSkill2);
                this.csintSkill3 = new DataColumn("sintSkill3", typeof(Int16), null, MappingType.Element);
                this.csintSkill3.AllowDBNull = true;
                this.csintSkill3.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintSkill3);
                this.csintSkill4 = new DataColumn("sintSkill4", typeof(Int16), null, MappingType.Element);
                this.csintSkill4.AllowDBNull = true;
                this.csintSkill4.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintSkill4);
                this.csintSkill5 = new DataColumn("sintSkill5", typeof(Int16), null, MappingType.Element);
                this.csintSkill5.AllowDBNull = true;
                this.csintSkill5.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintSkill5);
                this.csintSkill6 = new DataColumn("sintSkill6", typeof(Int16), null, MappingType.Element);
                this.csintSkill6.AllowDBNull = true;
                this.csintSkill6.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintSkill6);
                this.csintSkill7 = new DataColumn("sintSkill7", typeof(Int16), null, MappingType.Element);
                this.csintSkill7.AllowDBNull = true;
                this.csintSkill7.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintSkill7);
                this.cchrExpert = new DataColumn("chrExpert", typeof(String), null, MappingType.Element);
                this.cchrExpert.AllowDBNull = true;
                this.cchrExpert.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrExpert);
                this.cchrCallType = new DataColumn("chrCallType", typeof(String), null, MappingType.Element);
                this.cchrCallType.AllowDBNull = true;
                this.cchrCallType.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cchrCallType);
                this.csintWLNumber = new DataColumn("sintWLNumber", typeof(Int16), null, MappingType.Element);
                this.csintWLNumber.AllowDBNull = true;
                this.csintWLNumber.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintWLNumber);
                this.cintDistribMode = new DataColumn("intDistribMode", typeof(Int32), null, MappingType.Element);
                this.cintDistribMode.AllowDBNull = true;
                this.cintDistribMode.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintDistribMode);
                this.csintBLNumber = new DataColumn("sintBLNumber", typeof(Int16), null, MappingType.Element);
                this.csintBLNumber.AllowDBNull = true;
                this.csintBLNumber.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintBLNumber);
                this.csintIdIsm = new DataColumn("sintIdIsm", typeof(Int16), null, MappingType.Element);
                this.csintIdIsm.AllowDBNull = true;
                this.csintIdIsm.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintIdIsm);
                this.csintKeylcadc = new DataColumn("sintKeylcadc", typeof(Int16), null, MappingType.Element);
                this.csintKeylcadc.AllowDBNull = true;
                this.csintKeylcadc.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintKeylcadc);
                this.csintEmailTime = new DataColumn("sintEmailTime", typeof(Int16), null, MappingType.Element);
                this.csintEmailTime.AllowDBNull = true;
                this.csintEmailTime.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.csintEmailTime);
                this.cintGlobalCallId1 = new DataColumn("intGlobalCallId1", typeof(Int32), null, MappingType.Element);
                this.cintGlobalCallId1.AllowDBNull = true;
                this.cintGlobalCallId1.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintGlobalCallId1);
                this.cintGlobalCallId2 = new DataColumn("intGlobalCallId2", typeof(Int32), null, MappingType.Element);
                this.cintGlobalCallId2.AllowDBNull = true;
                this.cintGlobalCallId2.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cintGlobalCallId2);
                this.cdtmPeriod = new DataColumn("dtmPeriod", typeof(DateTime), null, MappingType.Element);
                this.cdtmPeriod.AllowDBNull = true;
                this.cdtmPeriod.ExtendedProperties.Add("Editable", "true");
                base.Columns.Add(this.cdtmPeriod);
                
			}

			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new tCRICommunicationRow(builder);
            }

            protected override global::System.Type GetRowType()
            {
                return typeof(tCRICommunicationRow);
            }

            public tCRICommunicationRow NewRow()
            {
                return (tCRICommunicationRow)base.NewRow();
            }
		}
		#endregion

		#region DataRow
		[Serializable()]
        public class tCRICommunicationRow : DataRow
        {
			private tCRICommunicationTable tabletCRICommunication;

			internal tCRICommunicationRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletCRICommunication = ((tCRICommunicationTable)(this.Table));
            }


			public Int64 IDCRICommunication{
get { return ((Int64)(this[this.tabletCRICommunication.cIDCRICommunication])); }
set{ this[this.tabletCRICommunication.cIDCRICommunication] = value; }
}
public Int64 IDCRIFile{
get { return ((Int64)(this[this.tabletCRICommunication.cIDCRIFile])); }
set{ this[this.tabletCRICommunication.cIDCRIFile] = value; }
}
public Int32? intTicketRef{
get {
if(this[this.tabletCRICommunication.cintTicketRef] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintTicketRef])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintTicketRef] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintTicketRef] = value; }
}
}

        public Int32? intParentTicketRef{
get {
if(this[this.tabletCRICommunication.cintParentTicketRef] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintParentTicketRef])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintParentTicketRef] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintParentTicketRef] = value; }
}
}

        public Int32? intChildTicketRef{
get {
if(this[this.tabletCRICommunication.cintChildTicketRef] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintChildTicketRef])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintChildTicketRef] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintChildTicketRef] = value; }
}
}

        public Int32? intBeginningDate{
get {
if(this[this.tabletCRICommunication.cintBeginningDate] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintBeginningDate])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintBeginningDate] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintBeginningDate] = value; }
}
}

        public Int32? intEndDate{
get {
if(this[this.tabletCRICommunication.cintEndDate] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintEndDate])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintEndDate] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintEndDate] = value; }
}
}

        public Int16? sintTrunkGroup{
get {
if(this[this.tabletCRICommunication.csintTrunkGroup] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintTrunkGroup])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintTrunkGroup] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintTrunkGroup] = value; }
}
}

        public Int16? sintPilotNumber{
get {
if(this[this.tabletCRICommunication.csintPilotNumber] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintPilotNumber])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintPilotNumber] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintPilotNumber] = value; }
}
}

        public Int16? sintReceptionGroup{
get {
if(this[this.tabletCRICommunication.csintReceptionGroup] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintReceptionGroup])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintReceptionGroup] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintReceptionGroup] = value; }
}
}

        public Int16? sintProcessingGroup{
get {
if(this[this.tabletCRICommunication.csintProcessingGroup] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintProcessingGroup])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintProcessingGroup] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintProcessingGroup] = value; }
}
}

        public Int16? sintDestAgent{
get {
if(this[this.tabletCRICommunication.csintDestAgent] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintDestAgent])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintDestAgent] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintDestAgent] = value; }
}
}

        public Int16? sintAnsweringAgent{
get {
if(this[this.tabletCRICommunication.csintAnsweringAgent] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintAnsweringAgent])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintAnsweringAgent] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintAnsweringAgent] = value; }
}
}

        public Int16? sintPreviousWaitingTime{
get {
if(this[this.tabletCRICommunication.csintPreviousWaitingTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintPreviousWaitingTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintPreviousWaitingTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintPreviousWaitingTime] = value; }
}
}

        public Int16? sintWaitingTime{
get {
if(this[this.tabletCRICommunication.csintWaitingTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintWaitingTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintWaitingTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintWaitingTime] = value; }
}
}

        public Int16? sintIvrWaitingTime{
get {
if(this[this.tabletCRICommunication.csintIvrWaitingTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintIvrWaitingTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintIvrWaitingTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintIvrWaitingTime] = value; }
}
}

        public Int16? sintRingingTime1{
get {
if(this[this.tabletCRICommunication.csintRingingTime1] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintRingingTime1])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintRingingTime1] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintRingingTime1] = value; }
}
}

        public Int16? sintRingingTime2{
get {
if(this[this.tabletCRICommunication.csintRingingTime2] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintRingingTime2])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintRingingTime2] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintRingingTime2] = value; }
}
}

        public Int16? sintTalkingTime{
get {
if(this[this.tabletCRICommunication.csintTalkingTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintTalkingTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintTalkingTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintTalkingTime] = value; }
}
}

        public Int16? sintCallOnHoldTime{
get {
if(this[this.tabletCRICommunication.csintCallOnHoldTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintCallOnHoldTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintCallOnHoldTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintCallOnHoldTime] = value; }
}
}

        public Int16? sintEnquiryDest1{
get {
if(this[this.tabletCRICommunication.csintEnquiryDest1] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintEnquiryDest1])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintEnquiryDest1] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintEnquiryDest1] = value; }
}
}

        public Int16? sintEnquiryTime1{
get {
if(this[this.tabletCRICommunication.csintEnquiryTime1] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintEnquiryTime1])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintEnquiryTime1] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintEnquiryTime1] = value; }
}
}

        public Int16? sintEnquiryDest2{
get {
if(this[this.tabletCRICommunication.csintEnquiryDest2] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintEnquiryDest2])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintEnquiryDest2] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintEnquiryDest2] = value; }
}
}

        public Int16? sintEnquiryTime2{
get {
if(this[this.tabletCRICommunication.csintEnquiryTime2] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintEnquiryTime2])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintEnquiryTime2] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintEnquiryTime2] = value; }
}
}

        public Int16? sintEnquiryDest3{
get {
if(this[this.tabletCRICommunication.csintEnquiryDest3] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintEnquiryDest3])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintEnquiryDest3] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintEnquiryDest3] = value; }
}
}

        public Int16? sintEnquiryTime3{
get {
if(this[this.tabletCRICommunication.csintEnquiryTime3] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintEnquiryTime3])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintEnquiryTime3] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintEnquiryTime3] = value; }
}
}

        public Int16? sintTransferDest{
get {
if(this[this.tabletCRICommunication.csintTransferDest] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintTransferDest])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintTransferDest] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintTransferDest] = value; }
}
}

        public Int16? sintTransactionTime{
get {
if(this[this.tabletCRICommunication.csintTransactionTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintTransactionTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintTransactionTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintTransactionTime] = value; }
}
}

        public String vchTransactionCode{
get {
if(this[this.tabletCRICommunication.cvchTransactionCode] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cvchTransactionCode])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cvchTransactionCode] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cvchTransactionCode] = value; }
}
}

        public String chrIntroGuideTime{
get {
if(this[this.tabletCRICommunication.cchrIntroGuideTime] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cchrIntroGuideTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cchrIntroGuideTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cchrIntroGuideTime] = value; }
}
}

        public Int16? sintIdPilotStat{
get {
if(this[this.tabletCRICommunication.csintIdPilotStat] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintIdPilotStat])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintIdPilotStat] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintIdPilotStat] = value; }
}
}

        public Int32? intCommReleaseDate{
get {
if(this[this.tabletCRICommunication.cintCommReleaseDate] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintCommReleaseDate])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintCommReleaseDate] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintCommReleaseDate] = value; }
}
}

        public Int16? sintWrapUpTime{
get {
if(this[this.tabletCRICommunication.csintWrapUpTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintWrapUpTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintWrapUpTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintWrapUpTime] = value; }
}
}

        public Int16? sintWrapUpActivationNumber{
get {
if(this[this.tabletCRICommunication.csintWrapUpActivationNumber] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintWrapUpActivationNumber])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintWrapUpActivationNumber] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintWrapUpActivationNumber] = value; }
}
}

        public Int16? sintPauseTime{
get {
if(this[this.tabletCRICommunication.csintPauseTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintPauseTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintPauseTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintPauseTime] = value; }
}
}

        public Int16? sintHelp{
get {
if(this[this.tabletCRICommunication.csintHelp] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintHelp])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintHelp] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintHelp] = value; }
}
}

        public Int16? sintVoiceGuideType{
get {
if(this[this.tabletCRICommunication.csintVoiceGuideType] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintVoiceGuideType])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintVoiceGuideType] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintVoiceGuideType] = value; }
}
}

        public String chrPilotState{
get {
if(this[this.tabletCRICommunication.cchrPilotState] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cchrPilotState])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cchrPilotState] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cchrPilotState] = value; }
}
}

        public String chrRecByMutualAid{
get {
if(this[this.tabletCRICommunication.cchrRecByMutualAid] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cchrRecByMutualAid])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cchrRecByMutualAid] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cchrRecByMutualAid] = value; }
}
}

        public String vchNDS{
get {
if(this[this.tabletCRICommunication.cvchNDS] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cvchNDS])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cvchNDS] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cvchNDS] = value; }
}
}

        public String vchInitialNumberCalled{
get {
if(this[this.tabletCRICommunication.cvchInitialNumberCalled] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cvchInitialNumberCalled])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cvchInitialNumberCalled] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cvchInitialNumberCalled] = value; }
}
}

        public Byte? tintCreatCause{
get {
if(this[this.tabletCRICommunication.ctintCreatCause] == DBNull.Value){ return null; }
else{ return ((Byte)(this[this.tabletCRICommunication.ctintCreatCause])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.ctintCreatCause] = DBNull.Value; }
else{ this[this.tabletCRICommunication.ctintCreatCause] = value; }
}
}

        public Byte? tintEndCause{
get {
if(this[this.tabletCRICommunication.ctintEndCause] == DBNull.Value){ return null; }
else{ return ((Byte)(this[this.tabletCRICommunication.ctintEndCause])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.ctintEndCause] = DBNull.Value; }
else{ this[this.tabletCRICommunication.ctintEndCause] = value; }
}
}

        public Int16? sintRecordTime{
get {
if(this[this.tabletCRICommunication.csintRecordTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintRecordTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintRecordTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintRecordTime] = value; }
}
}

        public Int32? intIVRTicketRef{
get {
if(this[this.tabletCRICommunication.cintIVRTicketRef] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintIVRTicketRef])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintIVRTicketRef] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintIVRTicketRef] = value; }
}
}

        public String vchCorrelatorData{
get {
if(this[this.tabletCRICommunication.cvchCorrelatorData] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cvchCorrelatorData])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cvchCorrelatorData] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cvchCorrelatorData] = value; }
}
}

        public Int16? sintSkill1{
get {
if(this[this.tabletCRICommunication.csintSkill1] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintSkill1])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintSkill1] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintSkill1] = value; }
}
}

        public Int16? sintSkill2{
get {
if(this[this.tabletCRICommunication.csintSkill2] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintSkill2])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintSkill2] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintSkill2] = value; }
}
}

        public Int16? sintSkill3{
get {
if(this[this.tabletCRICommunication.csintSkill3] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintSkill3])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintSkill3] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintSkill3] = value; }
}
}

        public Int16? sintSkill4{
get {
if(this[this.tabletCRICommunication.csintSkill4] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintSkill4])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintSkill4] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintSkill4] = value; }
}
}

        public Int16? sintSkill5{
get {
if(this[this.tabletCRICommunication.csintSkill5] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintSkill5])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintSkill5] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintSkill5] = value; }
}
}

        public Int16? sintSkill6{
get {
if(this[this.tabletCRICommunication.csintSkill6] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintSkill6])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintSkill6] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintSkill6] = value; }
}
}

        public Int16? sintSkill7{
get {
if(this[this.tabletCRICommunication.csintSkill7] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintSkill7])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintSkill7] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintSkill7] = value; }
}
}

        public String chrExpert{
get {
if(this[this.tabletCRICommunication.cchrExpert] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cchrExpert])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cchrExpert] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cchrExpert] = value; }
}
}

        public String chrCallType{
get {
if(this[this.tabletCRICommunication.cchrCallType] == DBNull.Value){ return null; }
else{ return ((String)(this[this.tabletCRICommunication.cchrCallType])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cchrCallType] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cchrCallType] = value; }
}
}

        public Int16? sintWLNumber{
get {
if(this[this.tabletCRICommunication.csintWLNumber] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintWLNumber])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintWLNumber] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintWLNumber] = value; }
}
}

        public Int32? intDistribMode{
get {
if(this[this.tabletCRICommunication.cintDistribMode] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintDistribMode])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintDistribMode] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintDistribMode] = value; }
}
}

        public Int16? sintBLNumber{
get {
if(this[this.tabletCRICommunication.csintBLNumber] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintBLNumber])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintBLNumber] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintBLNumber] = value; }
}
}

        public Int16? sintIdIsm{
get {
if(this[this.tabletCRICommunication.csintIdIsm] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintIdIsm])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintIdIsm] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintIdIsm] = value; }
}
}

        public Int16? sintKeylcadc{
get {
if(this[this.tabletCRICommunication.csintKeylcadc] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintKeylcadc])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintKeylcadc] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintKeylcadc] = value; }
}
}

        public Int16? sintEmailTime{
get {
if(this[this.tabletCRICommunication.csintEmailTime] == DBNull.Value){ return null; }
else{ return ((Int16)(this[this.tabletCRICommunication.csintEmailTime])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.csintEmailTime] = DBNull.Value; }
else{ this[this.tabletCRICommunication.csintEmailTime] = value; }
}
}

        public Int32? intGlobalCallId1{
get {
if(this[this.tabletCRICommunication.cintGlobalCallId1] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintGlobalCallId1])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintGlobalCallId1] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintGlobalCallId1] = value; }
}
}

        public Int32? intGlobalCallId2{
get {
if(this[this.tabletCRICommunication.cintGlobalCallId2] == DBNull.Value){ return null; }
else{ return ((Int32)(this[this.tabletCRICommunication.cintGlobalCallId2])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cintGlobalCallId2] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cintGlobalCallId2] = value; }
}
}

        public DateTime? dtmPeriod{
get {
if(this[this.tabletCRICommunication.cdtmPeriod] == DBNull.Value){ return null; }
else{ return ((DateTime)(this[this.tabletCRICommunication.cdtmPeriod])); }
}
        set{
if (value == null){ this[this.tabletCRICommunication.cdtmPeriod] = DBNull.Value; }
else{ this[this.tabletCRICommunication.cdtmPeriod] = value; }
}
}

        

            public Models.tCRICommunication GetModel()
            {
                Models.tCRICommunication model = new Models.tCRICommunication();

                model.IDCRICommunication = this.IDCRICommunication;
                model.IDCRIFile = this.IDCRIFile;
                model.intTicketRef = this.intTicketRef;
                model.intParentTicketRef = this.intParentTicketRef;
                model.intChildTicketRef = this.intChildTicketRef;
                model.intBeginningDate = this.intBeginningDate;
                model.intEndDate = this.intEndDate;
                model.sintTrunkGroup = this.sintTrunkGroup;
                model.sintPilotNumber = this.sintPilotNumber;
                model.sintReceptionGroup = this.sintReceptionGroup;
                model.sintProcessingGroup = this.sintProcessingGroup;
                model.sintDestAgent = this.sintDestAgent;
                model.sintAnsweringAgent = this.sintAnsweringAgent;
                model.sintPreviousWaitingTime = this.sintPreviousWaitingTime;
                model.sintWaitingTime = this.sintWaitingTime;
                model.sintIvrWaitingTime = this.sintIvrWaitingTime;
                model.sintRingingTime1 = this.sintRingingTime1;
                model.sintRingingTime2 = this.sintRingingTime2;
                model.sintTalkingTime = this.sintTalkingTime;
                model.sintCallOnHoldTime = this.sintCallOnHoldTime;
                model.sintEnquiryDest1 = this.sintEnquiryDest1;
                model.sintEnquiryTime1 = this.sintEnquiryTime1;
                model.sintEnquiryDest2 = this.sintEnquiryDest2;
                model.sintEnquiryTime2 = this.sintEnquiryTime2;
                model.sintEnquiryDest3 = this.sintEnquiryDest3;
                model.sintEnquiryTime3 = this.sintEnquiryTime3;
                model.sintTransferDest = this.sintTransferDest;
                model.sintTransactionTime = this.sintTransactionTime;
                model.vchTransactionCode = this.vchTransactionCode;
                model.chrIntroGuideTime = this.chrIntroGuideTime;
                model.sintIdPilotStat = this.sintIdPilotStat;
                model.intCommReleaseDate = this.intCommReleaseDate;
                model.sintWrapUpTime = this.sintWrapUpTime;
                model.sintWrapUpActivationNumber = this.sintWrapUpActivationNumber;
                model.sintPauseTime = this.sintPauseTime;
                model.sintHelp = this.sintHelp;
                model.sintVoiceGuideType = this.sintVoiceGuideType;
                model.chrPilotState = this.chrPilotState;
                model.chrRecByMutualAid = this.chrRecByMutualAid;
                model.vchNDS = this.vchNDS;
                model.vchInitialNumberCalled = this.vchInitialNumberCalled;
                model.tintCreatCause = this.tintCreatCause;
                model.tintEndCause = this.tintEndCause;
                model.sintRecordTime = this.sintRecordTime;
                model.intIVRTicketRef = this.intIVRTicketRef;
                model.vchCorrelatorData = this.vchCorrelatorData;
                model.sintSkill1 = this.sintSkill1;
                model.sintSkill2 = this.sintSkill2;
                model.sintSkill3 = this.sintSkill3;
                model.sintSkill4 = this.sintSkill4;
                model.sintSkill5 = this.sintSkill5;
                model.sintSkill6 = this.sintSkill6;
                model.sintSkill7 = this.sintSkill7;
                model.chrExpert = this.chrExpert;
                model.chrCallType = this.chrCallType;
                model.sintWLNumber = this.sintWLNumber;
                model.intDistribMode = this.intDistribMode;
                model.sintBLNumber = this.sintBLNumber;
                model.sintIdIsm = this.sintIdIsm;
                model.sintKeylcadc = this.sintKeylcadc;
                model.sintEmailTime = this.sintEmailTime;
                model.intGlobalCallId1 = this.intGlobalCallId1;
                model.intGlobalCallId2 = this.intGlobalCallId2;
                model.dtmPeriod = this.dtmPeriod;
                
                return model;
            }
		}
		#endregion

        #region Constructor and Columns

        public tCRICommunicationRow Columns
        {
            get
            {
                return (tCRICommunicationRow)this.Current;
            }
        }

		public tCRICommunicationTable Table
        {
            get
            {
                return (tCRICommunicationTable)this.Data.Tables[this.TableName];
            }
        }

        public tCRICommunication(): base("VoxCRI", "tCRICommunication")
        {
            this.Data.Tables.Add(new tCRICommunicationTable());
        }

        public tCRICommunication(Log oLog): base(oLog, "VoxCRI", "tCRICommunication")
        {
            this.Data.Tables.Add(new tCRICommunicationTable());
        }

        public IEnumerable<Models.tCRICommunication> GetModels()
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

        ~tCRICommunication()
        {
            this.Close(); base.Dispose();
        }

		#endregion

       
    }
}
