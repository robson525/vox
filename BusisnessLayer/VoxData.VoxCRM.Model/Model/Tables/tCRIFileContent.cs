using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tCRIFileContent : BindModel
    {

        [Key]
        public Int64 IDCRIFileContent { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: IDCRIFile")]
        [VoxDisplayName("IDCRIFile")]
        public Int64 IDCRIFile { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: dtmLoaded")]
        [VoxDisplayName("dtmLoaded")]
        public DateTime dtmLoaded { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: intVersion")]
        [VoxDisplayName("intVersion")]
        public Int32 intVersion { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: intLength")]
        [VoxDisplayName("intLength")]
        public Int32 intLength { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: intRead")]
        [VoxDisplayName("intRead")]
        public Int32 intRead { get; set; }

        
        public tCRIFileContent(){

        }
    }
}
