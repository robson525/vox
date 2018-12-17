using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class tLanguage : BindModel
    {

        [Key]
        public Int32 IDLanguage { get; set; }

        [VoxRequired("DFLT_Name")]
        [VoxStringLength(50, "DFLT_Name")]
        [VoxDisplayName("DFLT_Name")]
        public String vchName { get; set; }

        [VoxRequired("DFLT_CultureName")]
        [VoxStringLength(10, "DFLT_CultureName")]
        [VoxDisplayName("DFLT_CultureName")]
        public String vchCultureName { get; set; }

        [VoxRequired("DFLT_Editing")]
        [VoxDisplayName("DFLT_Editing")]
        public Boolean bitEditing { get; set; }

        
        public tLanguage(){

        }

        public tLanguage(int IDLanguage, string vchName, string vchCultureName)
        {
            this.IDLanguage = IDLanguage;
            this.vchName = vchName;
            this.vchCultureName = vchCultureName;
        }
    }
}
