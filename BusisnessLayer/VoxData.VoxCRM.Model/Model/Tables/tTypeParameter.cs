using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tTypeParameter : BindModel
    {

        [Key]
        public Int32 IDTypeParameter { get; set; }

        [VoxDisplayName("IDAUTOTypeParameter")]
        public Int32? IDAUTOTypeParameter { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: vchName")]
        [StringLength(100)]
        [VoxDisplayName("vchName")]
        public String vchName { get; set; }

        [StringLength(2147483647)]
        [VoxDisplayName("descTypeParameter")]
        public String descTypeParameter { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: bitAcvive")]
        [VoxDisplayName("bitAcvive")]
        public Boolean bitAcvive { get; set; }

        
        public tTypeParameter(){

        }
    }
}
