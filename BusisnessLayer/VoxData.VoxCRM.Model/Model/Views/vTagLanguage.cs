using System;

namespace VoxData.VoxCRM.Models
{
    public class vTagLanguage : BindModel
    {

        [VoxRequired("DFLT_Language")]
        [VoxDisplayName("DFLT_Language")]
        public Int32 IDLanguage { get; set; }

        [VoxRequired("DFLT_Tag")]
        [VoxDisplayName("DFLT_Tag")]
        public Int64 IDTag { get; set; }

        [VoxStringLength(2147483647, "DFLT_Text")]
        [VoxDisplayName("DFLT_Text")]
        public String vchText { get; set; }

        [VoxRequired("DFLT_TagName")]
        [VoxStringLength(400, "DFLT_TagName")]
        [VoxDisplayName("DFLT_TagName")]
        public String vchTagName { get; set; }

        [VoxRequired("DFLT_ExcludeTag")]
        [VoxDisplayName("DFLT_ExcludeTag")]
        public Boolean bitExcludeTag { get; set; }

        [VoxRequired("DFLT_LanguageName")]
        [VoxStringLength(50, "DFLT_LanguageName")]
        [VoxDisplayName("DFLT_LanguageName")]
        public String vchLanguageName { get; set; }

        [VoxRequired("DFLT_Culture")]
        [VoxStringLength(10, "DFLT_Culture")]
        [VoxDisplayName("DFLT_Culture")]
        public String vchCulture { get; set; }

        
        public vTagLanguage(){

        }
    }
}
