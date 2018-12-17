using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tCRICatalog : BindModel
    {

        [Key]
        public Int16 sintObjectId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: sintIdCl")]
        [VoxDisplayName("sintIdCl")]
        public Int16 sintIdCl { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: vchIdMao")]
        [StringLength(18)]
        [VoxDisplayName("vchIdMao")]
        public String vchIdMao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: chrObjectType")]
        [StringLength(1)]
        [VoxDisplayName("chrObjectType")]
        public String chrObjectType { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: vchMatricule")]
        [StringLength(10)]
        [VoxDisplayName("vchMatricule")]
        public String vchMatricule { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: intCreateDate")]
        [VoxDisplayName("intCreateDate")]
        public Int32 intCreateDate { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: intDeleteDate")]
        [VoxDisplayName("intDeleteDate")]
        public Int32 intDeleteDate { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: dtmCreateDate")]
        [VoxDisplayName("dtmCreateDate")]
        public DateTime dtmCreateDate { get; set; }

        [VoxDisplayName("dtmDeleteDate")]
        public DateTime? dtmDeleteDate { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: dtmLoaded")]
        [VoxDisplayName("dtmLoaded")]
        public DateTime dtmLoaded { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório: bitVisible")]
        [VoxDisplayName("bitVisible")]
        public Boolean bitVisible { get; set; }

        
        public tCRICatalog(){

        }
    }
}
