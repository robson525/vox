using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tCRIEvent : BindModel
    {

        [Key]
        public Int64 IDCRIEvent { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: IDCRIFile")]
        [VoxDisplayName("IDCRIFile")]
        public Int64 IDCRIFile { get; set; }

        [VoxDisplayName("intDateTicket")]
        public Int32? intDateTicket { get; set; }

        [VoxDisplayName("sintObjectId")]
        public Int16? sintObjectId { get; set; }

        [VoxDisplayName("intDate")]
        public Int32? intDate { get; set; }

        [StringLength(1)]
        [VoxDisplayName("chrState")]
        public String chrState { get; set; }

        [StringLength(1)]
        [VoxDisplayName("chrInfo")]
        public String chrInfo { get; set; }

        [VoxDisplayName("sintTeam")]
        public Int16? sintTeam { get; set; }

        [VoxDisplayName("dtmLoaded")]
        public DateTime? dtmLoaded { get; set; }

        
        public tCRIEvent(){

        }
    }
}
