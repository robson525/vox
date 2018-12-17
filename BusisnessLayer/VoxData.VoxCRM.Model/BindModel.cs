using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public abstract class BindModel : BindAction
    {
        public enum Operations
        {
            View,
            Create,
            Edit,            
            Delete
        }

        [JsonIgnore]
        [ScaffoldColumn(false)]
        public Operations Operation { get; set; }

        [JsonIgnore]
        [ScaffoldColumn(false)]
        public string OperationName
        {
            get
            {
                switch (this.Operation)
                {
                    case Operations.Create:
                        return Language.Instance.GetText("DFLT_Create");
                    case Operations.Edit:
                        return Language.Instance.GetText("DFLT_Edit");
                    case Operations.View:
                        return Language.Instance.GetText("DFLT_View");
                    case Operations.Delete:
                        return Language.Instance.GetText("DFLT_Delete");
                    default:
                        return "";
                }
            }
        }
        
    }
    
}
