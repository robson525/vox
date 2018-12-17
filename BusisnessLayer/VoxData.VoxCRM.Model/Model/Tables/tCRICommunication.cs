using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tCRICommunication : BindModel
    {

        [Key]
        public Int64 IDCRICommunication { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: IDCRIFile")]
        [VoxDisplayName("IDCRIFile")]
        public Int64 IDCRIFile { get; set; }

        [VoxDisplayName("intTicketRef")]
        public Int32? intTicketRef { get; set; }

        [VoxDisplayName("intParentTicketRef")]
        public Int32? intParentTicketRef { get; set; }

        [VoxDisplayName("intChildTicketRef")]
        public Int32? intChildTicketRef { get; set; }

        [VoxDisplayName("intBeginningDate")]
        public Int32? intBeginningDate { get; set; }

        [VoxDisplayName("intEndDate")]
        public Int32? intEndDate { get; set; }

        [VoxDisplayName("sintTrunkGroup")]
        public Int16? sintTrunkGroup { get; set; }

        [VoxDisplayName("sintPilotNumber")]
        public Int16? sintPilotNumber { get; set; }

        [VoxDisplayName("sintReceptionGroup")]
        public Int16? sintReceptionGroup { get; set; }

        [VoxDisplayName("sintProcessingGroup")]
        public Int16? sintProcessingGroup { get; set; }

        [VoxDisplayName("sintDestAgent")]
        public Int16? sintDestAgent { get; set; }

        [VoxDisplayName("sintAnsweringAgent")]
        public Int16? sintAnsweringAgent { get; set; }

        [VoxDisplayName("sintPreviousWaitingTime")]
        public Int16? sintPreviousWaitingTime { get; set; }

        [VoxDisplayName("sintWaitingTime")]
        public Int16? sintWaitingTime { get; set; }

        [VoxDisplayName("sintIvrWaitingTime")]
        public Int16? sintIvrWaitingTime { get; set; }

        [VoxDisplayName("sintRingingTime1")]
        public Int16? sintRingingTime1 { get; set; }

        [VoxDisplayName("sintRingingTime2")]
        public Int16? sintRingingTime2 { get; set; }

        [VoxDisplayName("sintTalkingTime")]
        public Int16? sintTalkingTime { get; set; }

        [VoxDisplayName("sintCallOnHoldTime")]
        public Int16? sintCallOnHoldTime { get; set; }

        [VoxDisplayName("sintEnquiryDest1")]
        public Int16? sintEnquiryDest1 { get; set; }

        [VoxDisplayName("sintEnquiryTime1")]
        public Int16? sintEnquiryTime1 { get; set; }

        [VoxDisplayName("sintEnquiryDest2")]
        public Int16? sintEnquiryDest2 { get; set; }

        [VoxDisplayName("sintEnquiryTime2")]
        public Int16? sintEnquiryTime2 { get; set; }

        [VoxDisplayName("sintEnquiryDest3")]
        public Int16? sintEnquiryDest3 { get; set; }

        [VoxDisplayName("sintEnquiryTime3")]
        public Int16? sintEnquiryTime3 { get; set; }

        [VoxDisplayName("sintTransferDest")]
        public Int16? sintTransferDest { get; set; }

        [VoxDisplayName("sintTransactionTime")]
        public Int16? sintTransactionTime { get; set; }

        [StringLength(15)]
        [VoxDisplayName("vchTransactionCode")]
        public String vchTransactionCode { get; set; }

        [StringLength(2)]
        [VoxDisplayName("chrIntroGuideTime")]
        public String chrIntroGuideTime { get; set; }

        [VoxDisplayName("sintIdPilotStat")]
        public Int16? sintIdPilotStat { get; set; }

        [VoxDisplayName("intCommReleaseDate")]
        public Int32? intCommReleaseDate { get; set; }

        [VoxDisplayName("sintWrapUpTime")]
        public Int16? sintWrapUpTime { get; set; }

        [VoxDisplayName("sintWrapUpActivationNumber")]
        public Int16? sintWrapUpActivationNumber { get; set; }

        [VoxDisplayName("sintPauseTime")]
        public Int16? sintPauseTime { get; set; }

        [VoxDisplayName("sintHelp")]
        public Int16? sintHelp { get; set; }

        [VoxDisplayName("sintVoiceGuideType")]
        public Int16? sintVoiceGuideType { get; set; }

        [StringLength(1)]
        [VoxDisplayName("chrPilotState")]
        public String chrPilotState { get; set; }

        [StringLength(1)]
        [VoxDisplayName("chrRecByMutualAid")]
        public String chrRecByMutualAid { get; set; }

        [StringLength(30)]
        [VoxDisplayName("vchNDS")]
        public String vchNDS { get; set; }

        [StringLength(30)]
        [VoxDisplayName("vchInitialNumberCalled")]
        public String vchInitialNumberCalled { get; set; }

        [VoxDisplayName("tintCreatCause")]
        public Byte? tintCreatCause { get; set; }

        [VoxDisplayName("tintEndCause")]
        public Byte? tintEndCause { get; set; }

        [VoxDisplayName("sintRecordTime")]
        public Int16? sintRecordTime { get; set; }

        [VoxDisplayName("intIVRTicketRef")]
        public Int32? intIVRTicketRef { get; set; }

        [StringLength(32)]
        [VoxDisplayName("vchCorrelatorData")]
        public String vchCorrelatorData { get; set; }

        [VoxDisplayName("sintSkill1")]
        public Int16? sintSkill1 { get; set; }

        [VoxDisplayName("sintSkill2")]
        public Int16? sintSkill2 { get; set; }

        [VoxDisplayName("sintSkill3")]
        public Int16? sintSkill3 { get; set; }

        [VoxDisplayName("sintSkill4")]
        public Int16? sintSkill4 { get; set; }

        [VoxDisplayName("sintSkill5")]
        public Int16? sintSkill5 { get; set; }

        [VoxDisplayName("sintSkill6")]
        public Int16? sintSkill6 { get; set; }

        [VoxDisplayName("sintSkill7")]
        public Int16? sintSkill7 { get; set; }

        [StringLength(7)]
        [VoxDisplayName("chrExpert")]
        public String chrExpert { get; set; }

        [StringLength(1)]
        [VoxDisplayName("chrCallType")]
        public String chrCallType { get; set; }

        [VoxDisplayName("sintWLNumber")]
        public Int16? sintWLNumber { get; set; }

        [VoxDisplayName("intDistribMode")]
        public Int32? intDistribMode { get; set; }

        [VoxDisplayName("sintBLNumber")]
        public Int16? sintBLNumber { get; set; }

        [VoxDisplayName("sintIdIsm")]
        public Int16? sintIdIsm { get; set; }

        [VoxDisplayName("sintKeylcadc")]
        public Int16? sintKeylcadc { get; set; }

        [VoxDisplayName("sintEmailTime")]
        public Int16? sintEmailTime { get; set; }

        [VoxDisplayName("intGlobalCallId1")]
        public Int32? intGlobalCallId1 { get; set; }

        [VoxDisplayName("intGlobalCallId2")]
        public Int32? intGlobalCallId2 { get; set; }

        [VoxDisplayName("dtmPeriod")]
        public DateTime? dtmPeriod { get; set; }

        
        public tCRICommunication(){

        }
    }
}
