using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tCRIFile : BindModel
    {

        [Key]
        public Int64 IDCRIFile { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: vchFileName")]
        [StringLength(15)]
        [VoxDisplayName("vchFileName")]
        public String vchFileName { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: dtmDateFile")]
        [DataType(DataType.Date)]
        [VoxDisplayName("dtmDateFile")]
        public DateTime dtmDateFile { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: bitClosed")]
        [VoxDisplayName("bitClosed")]
        public Boolean bitClosed { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: intPointer")]
        [VoxDisplayName("intPointer")]
        public Int32 intPointer { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: intErrors")]
        [VoxDisplayName("intErrors")]
        public Int32 intErrors { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: vchType")]
        [StringLength(2)]
        [VoxDisplayName("vchType")]
        public String vchType { get; set; }

        
        public tCRIFile(){

        }
    }
}
