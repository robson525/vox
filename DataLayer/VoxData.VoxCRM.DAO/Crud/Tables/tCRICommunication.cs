using System;
using System.Data;
using VoxData.Shared.DAO;

namespace VoxData.VoxCRM.DAO.Tables
{

    public partial class tCRICommunication
    {
		
        public bool GetData()
        {
            return Execute("SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) " + OrderBy());
        }
        
        public bool GetDataByID(Int64 pIDCRICommunication)
        {
            String sSQL = "SELECT " + this.GetColumns() + " FROM " + this.TableName + " WITH (NOLOCK) WHERE IDCRICommunication = " + pIDCRICommunication + " ";
            return Execute(sSQL);
        }

        public object Insert(tCRICommunicationRow pRow)
        {
            NewRow();

            Columns.IDCRIFile = pRow.IDCRIFile;
            Columns.intTicketRef = pRow.intTicketRef;
            Columns.intParentTicketRef = pRow.intParentTicketRef;
            Columns.intChildTicketRef = pRow.intChildTicketRef;
            Columns.intBeginningDate = pRow.intBeginningDate;
            Columns.intEndDate = pRow.intEndDate;
            Columns.sintTrunkGroup = pRow.sintTrunkGroup;
            Columns.sintPilotNumber = pRow.sintPilotNumber;
            Columns.sintReceptionGroup = pRow.sintReceptionGroup;
            Columns.sintProcessingGroup = pRow.sintProcessingGroup;
            Columns.sintDestAgent = pRow.sintDestAgent;
            Columns.sintAnsweringAgent = pRow.sintAnsweringAgent;
            Columns.sintPreviousWaitingTime = pRow.sintPreviousWaitingTime;
            Columns.sintWaitingTime = pRow.sintWaitingTime;
            Columns.sintIvrWaitingTime = pRow.sintIvrWaitingTime;
            Columns.sintRingingTime1 = pRow.sintRingingTime1;
            Columns.sintRingingTime2 = pRow.sintRingingTime2;
            Columns.sintTalkingTime = pRow.sintTalkingTime;
            Columns.sintCallOnHoldTime = pRow.sintCallOnHoldTime;
            Columns.sintEnquiryDest1 = pRow.sintEnquiryDest1;
            Columns.sintEnquiryTime1 = pRow.sintEnquiryTime1;
            Columns.sintEnquiryDest2 = pRow.sintEnquiryDest2;
            Columns.sintEnquiryTime2 = pRow.sintEnquiryTime2;
            Columns.sintEnquiryDest3 = pRow.sintEnquiryDest3;
            Columns.sintEnquiryTime3 = pRow.sintEnquiryTime3;
            Columns.sintTransferDest = pRow.sintTransferDest;
            Columns.sintTransactionTime = pRow.sintTransactionTime;
            Columns.vchTransactionCode = pRow.vchTransactionCode;
            Columns.chrIntroGuideTime = pRow.chrIntroGuideTime;
            Columns.sintIdPilotStat = pRow.sintIdPilotStat;
            Columns.intCommReleaseDate = pRow.intCommReleaseDate;
            Columns.sintWrapUpTime = pRow.sintWrapUpTime;
            Columns.sintWrapUpActivationNumber = pRow.sintWrapUpActivationNumber;
            Columns.sintPauseTime = pRow.sintPauseTime;
            Columns.sintHelp = pRow.sintHelp;
            Columns.sintVoiceGuideType = pRow.sintVoiceGuideType;
            Columns.chrPilotState = pRow.chrPilotState;
            Columns.chrRecByMutualAid = pRow.chrRecByMutualAid;
            Columns.vchNDS = pRow.vchNDS;
            Columns.vchInitialNumberCalled = pRow.vchInitialNumberCalled;
            Columns.tintCreatCause = pRow.tintCreatCause;
            Columns.tintEndCause = pRow.tintEndCause;
            Columns.sintRecordTime = pRow.sintRecordTime;
            Columns.intIVRTicketRef = pRow.intIVRTicketRef;
            Columns.vchCorrelatorData = pRow.vchCorrelatorData;
            Columns.sintSkill1 = pRow.sintSkill1;
            Columns.sintSkill2 = pRow.sintSkill2;
            Columns.sintSkill3 = pRow.sintSkill3;
            Columns.sintSkill4 = pRow.sintSkill4;
            Columns.sintSkill5 = pRow.sintSkill5;
            Columns.sintSkill6 = pRow.sintSkill6;
            Columns.sintSkill7 = pRow.sintSkill7;
            Columns.chrExpert = pRow.chrExpert;
            Columns.chrCallType = pRow.chrCallType;
            Columns.sintWLNumber = pRow.sintWLNumber;
            Columns.intDistribMode = pRow.intDistribMode;
            Columns.sintBLNumber = pRow.sintBLNumber;
            Columns.sintIdIsm = pRow.sintIdIsm;
            Columns.sintKeylcadc = pRow.sintKeylcadc;
            Columns.sintEmailTime = pRow.sintEmailTime;
            Columns.intGlobalCallId1 = pRow.intGlobalCallId1;
            Columns.intGlobalCallId2 = pRow.intGlobalCallId2;
            Columns.dtmPeriod = pRow.dtmPeriod;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Models.tCRICommunication pModel)
        {
            NewRow();

            Columns.IDCRIFile = pModel.IDCRIFile;
            Columns.intTicketRef = pModel.intTicketRef;
            Columns.intParentTicketRef = pModel.intParentTicketRef;
            Columns.intChildTicketRef = pModel.intChildTicketRef;
            Columns.intBeginningDate = pModel.intBeginningDate;
            Columns.intEndDate = pModel.intEndDate;
            Columns.sintTrunkGroup = pModel.sintTrunkGroup;
            Columns.sintPilotNumber = pModel.sintPilotNumber;
            Columns.sintReceptionGroup = pModel.sintReceptionGroup;
            Columns.sintProcessingGroup = pModel.sintProcessingGroup;
            Columns.sintDestAgent = pModel.sintDestAgent;
            Columns.sintAnsweringAgent = pModel.sintAnsweringAgent;
            Columns.sintPreviousWaitingTime = pModel.sintPreviousWaitingTime;
            Columns.sintWaitingTime = pModel.sintWaitingTime;
            Columns.sintIvrWaitingTime = pModel.sintIvrWaitingTime;
            Columns.sintRingingTime1 = pModel.sintRingingTime1;
            Columns.sintRingingTime2 = pModel.sintRingingTime2;
            Columns.sintTalkingTime = pModel.sintTalkingTime;
            Columns.sintCallOnHoldTime = pModel.sintCallOnHoldTime;
            Columns.sintEnquiryDest1 = pModel.sintEnquiryDest1;
            Columns.sintEnquiryTime1 = pModel.sintEnquiryTime1;
            Columns.sintEnquiryDest2 = pModel.sintEnquiryDest2;
            Columns.sintEnquiryTime2 = pModel.sintEnquiryTime2;
            Columns.sintEnquiryDest3 = pModel.sintEnquiryDest3;
            Columns.sintEnquiryTime3 = pModel.sintEnquiryTime3;
            Columns.sintTransferDest = pModel.sintTransferDest;
            Columns.sintTransactionTime = pModel.sintTransactionTime;
            Columns.vchTransactionCode = pModel.vchTransactionCode;
            Columns.chrIntroGuideTime = pModel.chrIntroGuideTime;
            Columns.sintIdPilotStat = pModel.sintIdPilotStat;
            Columns.intCommReleaseDate = pModel.intCommReleaseDate;
            Columns.sintWrapUpTime = pModel.sintWrapUpTime;
            Columns.sintWrapUpActivationNumber = pModel.sintWrapUpActivationNumber;
            Columns.sintPauseTime = pModel.sintPauseTime;
            Columns.sintHelp = pModel.sintHelp;
            Columns.sintVoiceGuideType = pModel.sintVoiceGuideType;
            Columns.chrPilotState = pModel.chrPilotState;
            Columns.chrRecByMutualAid = pModel.chrRecByMutualAid;
            Columns.vchNDS = pModel.vchNDS;
            Columns.vchInitialNumberCalled = pModel.vchInitialNumberCalled;
            Columns.tintCreatCause = pModel.tintCreatCause;
            Columns.tintEndCause = pModel.tintEndCause;
            Columns.sintRecordTime = pModel.sintRecordTime;
            Columns.intIVRTicketRef = pModel.intIVRTicketRef;
            Columns.vchCorrelatorData = pModel.vchCorrelatorData;
            Columns.sintSkill1 = pModel.sintSkill1;
            Columns.sintSkill2 = pModel.sintSkill2;
            Columns.sintSkill3 = pModel.sintSkill3;
            Columns.sintSkill4 = pModel.sintSkill4;
            Columns.sintSkill5 = pModel.sintSkill5;
            Columns.sintSkill6 = pModel.sintSkill6;
            Columns.sintSkill7 = pModel.sintSkill7;
            Columns.chrExpert = pModel.chrExpert;
            Columns.chrCallType = pModel.chrCallType;
            Columns.sintWLNumber = pModel.sintWLNumber;
            Columns.intDistribMode = pModel.intDistribMode;
            Columns.sintBLNumber = pModel.sintBLNumber;
            Columns.sintIdIsm = pModel.sintIdIsm;
            Columns.sintKeylcadc = pModel.sintKeylcadc;
            Columns.sintEmailTime = pModel.sintEmailTime;
            Columns.intGlobalCallId1 = pModel.intGlobalCallId1;
            Columns.intGlobalCallId2 = pModel.intGlobalCallId2;
            Columns.dtmPeriod = pModel.dtmPeriod;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Insert(Int64 pIDCRIFile, Int32? pintTicketRef, Int32? pintParentTicketRef, Int32? pintChildTicketRef, Int32? pintBeginningDate, Int32? pintEndDate, Int16? psintTrunkGroup, Int16? psintPilotNumber, Int16? psintReceptionGroup, Int16? psintProcessingGroup, Int16? psintDestAgent, Int16? psintAnsweringAgent, Int16? psintPreviousWaitingTime, Int16? psintWaitingTime, Int16? psintIvrWaitingTime, Int16? psintRingingTime1, Int16? psintRingingTime2, Int16? psintTalkingTime, Int16? psintCallOnHoldTime, Int16? psintEnquiryDest1, Int16? psintEnquiryTime1, Int16? psintEnquiryDest2, Int16? psintEnquiryTime2, Int16? psintEnquiryDest3, Int16? psintEnquiryTime3, Int16? psintTransferDest, Int16? psintTransactionTime, String pvchTransactionCode, String pchrIntroGuideTime, Int16? psintIdPilotStat, Int32? pintCommReleaseDate, Int16? psintWrapUpTime, Int16? psintWrapUpActivationNumber, Int16? psintPauseTime, Int16? psintHelp, Int16? psintVoiceGuideType, String pchrPilotState, String pchrRecByMutualAid, String pvchNDS, String pvchInitialNumberCalled, Byte? ptintCreatCause, Byte? ptintEndCause, Int16? psintRecordTime, Int32? pintIVRTicketRef, String pvchCorrelatorData, Int16? psintSkill1, Int16? psintSkill2, Int16? psintSkill3, Int16? psintSkill4, Int16? psintSkill5, Int16? psintSkill6, Int16? psintSkill7, String pchrExpert, String pchrCallType, Int16? psintWLNumber, Int32? pintDistribMode, Int16? psintBLNumber, Int16? psintIdIsm, Int16? psintKeylcadc, Int16? psintEmailTime, Int32? pintGlobalCallId1, Int32? pintGlobalCallId2, DateTime? pdtmPeriod)
        {
            NewRow();

            Columns.IDCRIFile = pIDCRIFile;
            Columns.intTicketRef = pintTicketRef;
            Columns.intParentTicketRef = pintParentTicketRef;
            Columns.intChildTicketRef = pintChildTicketRef;
            Columns.intBeginningDate = pintBeginningDate;
            Columns.intEndDate = pintEndDate;
            Columns.sintTrunkGroup = psintTrunkGroup;
            Columns.sintPilotNumber = psintPilotNumber;
            Columns.sintReceptionGroup = psintReceptionGroup;
            Columns.sintProcessingGroup = psintProcessingGroup;
            Columns.sintDestAgent = psintDestAgent;
            Columns.sintAnsweringAgent = psintAnsweringAgent;
            Columns.sintPreviousWaitingTime = psintPreviousWaitingTime;
            Columns.sintWaitingTime = psintWaitingTime;
            Columns.sintIvrWaitingTime = psintIvrWaitingTime;
            Columns.sintRingingTime1 = psintRingingTime1;
            Columns.sintRingingTime2 = psintRingingTime2;
            Columns.sintTalkingTime = psintTalkingTime;
            Columns.sintCallOnHoldTime = psintCallOnHoldTime;
            Columns.sintEnquiryDest1 = psintEnquiryDest1;
            Columns.sintEnquiryTime1 = psintEnquiryTime1;
            Columns.sintEnquiryDest2 = psintEnquiryDest2;
            Columns.sintEnquiryTime2 = psintEnquiryTime2;
            Columns.sintEnquiryDest3 = psintEnquiryDest3;
            Columns.sintEnquiryTime3 = psintEnquiryTime3;
            Columns.sintTransferDest = psintTransferDest;
            Columns.sintTransactionTime = psintTransactionTime;
            Columns.vchTransactionCode = pvchTransactionCode;
            Columns.chrIntroGuideTime = pchrIntroGuideTime;
            Columns.sintIdPilotStat = psintIdPilotStat;
            Columns.intCommReleaseDate = pintCommReleaseDate;
            Columns.sintWrapUpTime = psintWrapUpTime;
            Columns.sintWrapUpActivationNumber = psintWrapUpActivationNumber;
            Columns.sintPauseTime = psintPauseTime;
            Columns.sintHelp = psintHelp;
            Columns.sintVoiceGuideType = psintVoiceGuideType;
            Columns.chrPilotState = pchrPilotState;
            Columns.chrRecByMutualAid = pchrRecByMutualAid;
            Columns.vchNDS = pvchNDS;
            Columns.vchInitialNumberCalled = pvchInitialNumberCalled;
            Columns.tintCreatCause = ptintCreatCause;
            Columns.tintEndCause = ptintEndCause;
            Columns.sintRecordTime = psintRecordTime;
            Columns.intIVRTicketRef = pintIVRTicketRef;
            Columns.vchCorrelatorData = pvchCorrelatorData;
            Columns.sintSkill1 = psintSkill1;
            Columns.sintSkill2 = psintSkill2;
            Columns.sintSkill3 = psintSkill3;
            Columns.sintSkill4 = psintSkill4;
            Columns.sintSkill5 = psintSkill5;
            Columns.sintSkill6 = psintSkill6;
            Columns.sintSkill7 = psintSkill7;
            Columns.chrExpert = pchrExpert;
            Columns.chrCallType = pchrCallType;
            Columns.sintWLNumber = psintWLNumber;
            Columns.intDistribMode = pintDistribMode;
            Columns.sintBLNumber = psintBLNumber;
            Columns.sintIdIsm = psintIdIsm;
            Columns.sintKeylcadc = psintKeylcadc;
            Columns.sintEmailTime = psintEmailTime;
            Columns.intGlobalCallId1 = pintGlobalCallId1;
            Columns.intGlobalCallId2 = pintGlobalCallId2;
            Columns.dtmPeriod = pdtmPeriod;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(tCRICommunicationRow pRow)
        {
            if (base.Eof() || (this.Columns.IDCRICommunication != pRow.IDCRICommunication ))
                GetDataByID(pRow.IDCRICommunication);

            Columns.IDCRIFile = pRow.IDCRIFile;
            Columns.intTicketRef = pRow.intTicketRef;
            Columns.intParentTicketRef = pRow.intParentTicketRef;
            Columns.intChildTicketRef = pRow.intChildTicketRef;
            Columns.intBeginningDate = pRow.intBeginningDate;
            Columns.intEndDate = pRow.intEndDate;
            Columns.sintTrunkGroup = pRow.sintTrunkGroup;
            Columns.sintPilotNumber = pRow.sintPilotNumber;
            Columns.sintReceptionGroup = pRow.sintReceptionGroup;
            Columns.sintProcessingGroup = pRow.sintProcessingGroup;
            Columns.sintDestAgent = pRow.sintDestAgent;
            Columns.sintAnsweringAgent = pRow.sintAnsweringAgent;
            Columns.sintPreviousWaitingTime = pRow.sintPreviousWaitingTime;
            Columns.sintWaitingTime = pRow.sintWaitingTime;
            Columns.sintIvrWaitingTime = pRow.sintIvrWaitingTime;
            Columns.sintRingingTime1 = pRow.sintRingingTime1;
            Columns.sintRingingTime2 = pRow.sintRingingTime2;
            Columns.sintTalkingTime = pRow.sintTalkingTime;
            Columns.sintCallOnHoldTime = pRow.sintCallOnHoldTime;
            Columns.sintEnquiryDest1 = pRow.sintEnquiryDest1;
            Columns.sintEnquiryTime1 = pRow.sintEnquiryTime1;
            Columns.sintEnquiryDest2 = pRow.sintEnquiryDest2;
            Columns.sintEnquiryTime2 = pRow.sintEnquiryTime2;
            Columns.sintEnquiryDest3 = pRow.sintEnquiryDest3;
            Columns.sintEnquiryTime3 = pRow.sintEnquiryTime3;
            Columns.sintTransferDest = pRow.sintTransferDest;
            Columns.sintTransactionTime = pRow.sintTransactionTime;
            Columns.vchTransactionCode = pRow.vchTransactionCode;
            Columns.chrIntroGuideTime = pRow.chrIntroGuideTime;
            Columns.sintIdPilotStat = pRow.sintIdPilotStat;
            Columns.intCommReleaseDate = pRow.intCommReleaseDate;
            Columns.sintWrapUpTime = pRow.sintWrapUpTime;
            Columns.sintWrapUpActivationNumber = pRow.sintWrapUpActivationNumber;
            Columns.sintPauseTime = pRow.sintPauseTime;
            Columns.sintHelp = pRow.sintHelp;
            Columns.sintVoiceGuideType = pRow.sintVoiceGuideType;
            Columns.chrPilotState = pRow.chrPilotState;
            Columns.chrRecByMutualAid = pRow.chrRecByMutualAid;
            Columns.vchNDS = pRow.vchNDS;
            Columns.vchInitialNumberCalled = pRow.vchInitialNumberCalled;
            Columns.tintCreatCause = pRow.tintCreatCause;
            Columns.tintEndCause = pRow.tintEndCause;
            Columns.sintRecordTime = pRow.sintRecordTime;
            Columns.intIVRTicketRef = pRow.intIVRTicketRef;
            Columns.vchCorrelatorData = pRow.vchCorrelatorData;
            Columns.sintSkill1 = pRow.sintSkill1;
            Columns.sintSkill2 = pRow.sintSkill2;
            Columns.sintSkill3 = pRow.sintSkill3;
            Columns.sintSkill4 = pRow.sintSkill4;
            Columns.sintSkill5 = pRow.sintSkill5;
            Columns.sintSkill6 = pRow.sintSkill6;
            Columns.sintSkill7 = pRow.sintSkill7;
            Columns.chrExpert = pRow.chrExpert;
            Columns.chrCallType = pRow.chrCallType;
            Columns.sintWLNumber = pRow.sintWLNumber;
            Columns.intDistribMode = pRow.intDistribMode;
            Columns.sintBLNumber = pRow.sintBLNumber;
            Columns.sintIdIsm = pRow.sintIdIsm;
            Columns.sintKeylcadc = pRow.sintKeylcadc;
            Columns.sintEmailTime = pRow.sintEmailTime;
            Columns.intGlobalCallId1 = pRow.intGlobalCallId1;
            Columns.intGlobalCallId2 = pRow.intGlobalCallId2;
            Columns.dtmPeriod = pRow.dtmPeriod;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Models.tCRICommunication pModel)
        {
            if (base.Eof() || (this.Columns.IDCRICommunication != pModel.IDCRICommunication ))
                GetDataByID(pModel.IDCRICommunication);

            Columns.IDCRIFile = pModel.IDCRIFile;
            Columns.intTicketRef = pModel.intTicketRef;
            Columns.intParentTicketRef = pModel.intParentTicketRef;
            Columns.intChildTicketRef = pModel.intChildTicketRef;
            Columns.intBeginningDate = pModel.intBeginningDate;
            Columns.intEndDate = pModel.intEndDate;
            Columns.sintTrunkGroup = pModel.sintTrunkGroup;
            Columns.sintPilotNumber = pModel.sintPilotNumber;
            Columns.sintReceptionGroup = pModel.sintReceptionGroup;
            Columns.sintProcessingGroup = pModel.sintProcessingGroup;
            Columns.sintDestAgent = pModel.sintDestAgent;
            Columns.sintAnsweringAgent = pModel.sintAnsweringAgent;
            Columns.sintPreviousWaitingTime = pModel.sintPreviousWaitingTime;
            Columns.sintWaitingTime = pModel.sintWaitingTime;
            Columns.sintIvrWaitingTime = pModel.sintIvrWaitingTime;
            Columns.sintRingingTime1 = pModel.sintRingingTime1;
            Columns.sintRingingTime2 = pModel.sintRingingTime2;
            Columns.sintTalkingTime = pModel.sintTalkingTime;
            Columns.sintCallOnHoldTime = pModel.sintCallOnHoldTime;
            Columns.sintEnquiryDest1 = pModel.sintEnquiryDest1;
            Columns.sintEnquiryTime1 = pModel.sintEnquiryTime1;
            Columns.sintEnquiryDest2 = pModel.sintEnquiryDest2;
            Columns.sintEnquiryTime2 = pModel.sintEnquiryTime2;
            Columns.sintEnquiryDest3 = pModel.sintEnquiryDest3;
            Columns.sintEnquiryTime3 = pModel.sintEnquiryTime3;
            Columns.sintTransferDest = pModel.sintTransferDest;
            Columns.sintTransactionTime = pModel.sintTransactionTime;
            Columns.vchTransactionCode = pModel.vchTransactionCode;
            Columns.chrIntroGuideTime = pModel.chrIntroGuideTime;
            Columns.sintIdPilotStat = pModel.sintIdPilotStat;
            Columns.intCommReleaseDate = pModel.intCommReleaseDate;
            Columns.sintWrapUpTime = pModel.sintWrapUpTime;
            Columns.sintWrapUpActivationNumber = pModel.sintWrapUpActivationNumber;
            Columns.sintPauseTime = pModel.sintPauseTime;
            Columns.sintHelp = pModel.sintHelp;
            Columns.sintVoiceGuideType = pModel.sintVoiceGuideType;
            Columns.chrPilotState = pModel.chrPilotState;
            Columns.chrRecByMutualAid = pModel.chrRecByMutualAid;
            Columns.vchNDS = pModel.vchNDS;
            Columns.vchInitialNumberCalled = pModel.vchInitialNumberCalled;
            Columns.tintCreatCause = pModel.tintCreatCause;
            Columns.tintEndCause = pModel.tintEndCause;
            Columns.sintRecordTime = pModel.sintRecordTime;
            Columns.intIVRTicketRef = pModel.intIVRTicketRef;
            Columns.vchCorrelatorData = pModel.vchCorrelatorData;
            Columns.sintSkill1 = pModel.sintSkill1;
            Columns.sintSkill2 = pModel.sintSkill2;
            Columns.sintSkill3 = pModel.sintSkill3;
            Columns.sintSkill4 = pModel.sintSkill4;
            Columns.sintSkill5 = pModel.sintSkill5;
            Columns.sintSkill6 = pModel.sintSkill6;
            Columns.sintSkill7 = pModel.sintSkill7;
            Columns.chrExpert = pModel.chrExpert;
            Columns.chrCallType = pModel.chrCallType;
            Columns.sintWLNumber = pModel.sintWLNumber;
            Columns.intDistribMode = pModel.intDistribMode;
            Columns.sintBLNumber = pModel.sintBLNumber;
            Columns.sintIdIsm = pModel.sintIdIsm;
            Columns.sintKeylcadc = pModel.sintKeylcadc;
            Columns.sintEmailTime = pModel.sintEmailTime;
            Columns.intGlobalCallId1 = pModel.intGlobalCallId1;
            Columns.intGlobalCallId2 = pModel.intGlobalCallId2;
            Columns.dtmPeriod = pModel.dtmPeriod;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Update(Int64 pIDCRICommunication, Int64 pIDCRIFile, Int32? pintTicketRef, Int32? pintParentTicketRef, Int32? pintChildTicketRef, Int32? pintBeginningDate, Int32? pintEndDate, Int16? psintTrunkGroup, Int16? psintPilotNumber, Int16? psintReceptionGroup, Int16? psintProcessingGroup, Int16? psintDestAgent, Int16? psintAnsweringAgent, Int16? psintPreviousWaitingTime, Int16? psintWaitingTime, Int16? psintIvrWaitingTime, Int16? psintRingingTime1, Int16? psintRingingTime2, Int16? psintTalkingTime, Int16? psintCallOnHoldTime, Int16? psintEnquiryDest1, Int16? psintEnquiryTime1, Int16? psintEnquiryDest2, Int16? psintEnquiryTime2, Int16? psintEnquiryDest3, Int16? psintEnquiryTime3, Int16? psintTransferDest, Int16? psintTransactionTime, String pvchTransactionCode, String pchrIntroGuideTime, Int16? psintIdPilotStat, Int32? pintCommReleaseDate, Int16? psintWrapUpTime, Int16? psintWrapUpActivationNumber, Int16? psintPauseTime, Int16? psintHelp, Int16? psintVoiceGuideType, String pchrPilotState, String pchrRecByMutualAid, String pvchNDS, String pvchInitialNumberCalled, Byte? ptintCreatCause, Byte? ptintEndCause, Int16? psintRecordTime, Int32? pintIVRTicketRef, String pvchCorrelatorData, Int16? psintSkill1, Int16? psintSkill2, Int16? psintSkill3, Int16? psintSkill4, Int16? psintSkill5, Int16? psintSkill6, Int16? psintSkill7, String pchrExpert, String pchrCallType, Int16? psintWLNumber, Int32? pintDistribMode, Int16? psintBLNumber, Int16? psintIdIsm, Int16? psintKeylcadc, Int16? psintEmailTime, Int32? pintGlobalCallId1, Int32? pintGlobalCallId2, DateTime? pdtmPeriod)
        {
            GetDataByID(pIDCRICommunication);

            Columns.IDCRIFile = pIDCRIFile;
            Columns.intTicketRef = pintTicketRef;
            Columns.intParentTicketRef = pintParentTicketRef;
            Columns.intChildTicketRef = pintChildTicketRef;
            Columns.intBeginningDate = pintBeginningDate;
            Columns.intEndDate = pintEndDate;
            Columns.sintTrunkGroup = psintTrunkGroup;
            Columns.sintPilotNumber = psintPilotNumber;
            Columns.sintReceptionGroup = psintReceptionGroup;
            Columns.sintProcessingGroup = psintProcessingGroup;
            Columns.sintDestAgent = psintDestAgent;
            Columns.sintAnsweringAgent = psintAnsweringAgent;
            Columns.sintPreviousWaitingTime = psintPreviousWaitingTime;
            Columns.sintWaitingTime = psintWaitingTime;
            Columns.sintIvrWaitingTime = psintIvrWaitingTime;
            Columns.sintRingingTime1 = psintRingingTime1;
            Columns.sintRingingTime2 = psintRingingTime2;
            Columns.sintTalkingTime = psintTalkingTime;
            Columns.sintCallOnHoldTime = psintCallOnHoldTime;
            Columns.sintEnquiryDest1 = psintEnquiryDest1;
            Columns.sintEnquiryTime1 = psintEnquiryTime1;
            Columns.sintEnquiryDest2 = psintEnquiryDest2;
            Columns.sintEnquiryTime2 = psintEnquiryTime2;
            Columns.sintEnquiryDest3 = psintEnquiryDest3;
            Columns.sintEnquiryTime3 = psintEnquiryTime3;
            Columns.sintTransferDest = psintTransferDest;
            Columns.sintTransactionTime = psintTransactionTime;
            Columns.vchTransactionCode = pvchTransactionCode;
            Columns.chrIntroGuideTime = pchrIntroGuideTime;
            Columns.sintIdPilotStat = psintIdPilotStat;
            Columns.intCommReleaseDate = pintCommReleaseDate;
            Columns.sintWrapUpTime = psintWrapUpTime;
            Columns.sintWrapUpActivationNumber = psintWrapUpActivationNumber;
            Columns.sintPauseTime = psintPauseTime;
            Columns.sintHelp = psintHelp;
            Columns.sintVoiceGuideType = psintVoiceGuideType;
            Columns.chrPilotState = pchrPilotState;
            Columns.chrRecByMutualAid = pchrRecByMutualAid;
            Columns.vchNDS = pvchNDS;
            Columns.vchInitialNumberCalled = pvchInitialNumberCalled;
            Columns.tintCreatCause = ptintCreatCause;
            Columns.tintEndCause = ptintEndCause;
            Columns.sintRecordTime = psintRecordTime;
            Columns.intIVRTicketRef = pintIVRTicketRef;
            Columns.vchCorrelatorData = pvchCorrelatorData;
            Columns.sintSkill1 = psintSkill1;
            Columns.sintSkill2 = psintSkill2;
            Columns.sintSkill3 = psintSkill3;
            Columns.sintSkill4 = psintSkill4;
            Columns.sintSkill5 = psintSkill5;
            Columns.sintSkill6 = psintSkill6;
            Columns.sintSkill7 = psintSkill7;
            Columns.chrExpert = pchrExpert;
            Columns.chrCallType = pchrCallType;
            Columns.sintWLNumber = psintWLNumber;
            Columns.intDistribMode = pintDistribMode;
            Columns.sintBLNumber = psintBLNumber;
            Columns.sintIdIsm = psintIdIsm;
            Columns.sintKeylcadc = psintKeylcadc;
            Columns.sintEmailTime = psintEmailTime;
            Columns.intGlobalCallId1 = pintGlobalCallId1;
            Columns.intGlobalCallId2 = pintGlobalCallId2;
            Columns.dtmPeriod = pdtmPeriod;
            
            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

        public object Delete(Int64 pIDCRICommunication)
        {
            GetDataByID(pIDCRICommunication);

            this.DeleteRow();

            object lResult = Apply(TConnectionSQL.ExecuteType.ExecuteScalar);

            return lResult;
        }

    }
}
