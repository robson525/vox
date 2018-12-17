using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VoxData.VoxCRM.Models
{
    public class VoxDisplayName : DisplayNameAttribute
    {
        public VoxDisplayName(string tag) : base()
        {
            base.DisplayNameValue = Language.Instance.GetText(tag);
        }
    }

    public class VoxRequired : RequiredAttribute
    {
        public VoxRequired(string tag)
        {
            base.ErrorMessage = string.Format(Language.Instance.GetText("TAG_RequiredFild"), Language.Instance.GetText(tag));
        }
    }

    public class VoxStringLength : StringLengthAttribute
    {
        public VoxStringLength(int maximumLength, string tag) : base(maximumLength)
        {
            base.ErrorMessage = string.Format(Language.Instance.GetText("TAG_MaxLengthFild"), Language.Instance.GetText(tag));
        }
    }
    
}
