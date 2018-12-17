using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tParameter : BindModel
    {

        [Key]
        public String IDParameter { get; set; }

        [VoxDisplayName("IDTypeParameter")]
        public Int32? IDTypeParameter { get; set; }

        [StringLength(2147483647)]
        [VoxDisplayName("vchValue")]
        public String vchValue { get; set; }

        [StringLength(100)]
        [VoxDisplayName("vchTypeValue")]
        public String vchTypeValue { get; set; }

        
        public tParameter(){

        }
    }
}
