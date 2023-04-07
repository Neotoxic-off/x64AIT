using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class clto : BaseModel<object?>
    {
        public clto() : base("clto", null)
        {
            Comment = $"Convert quadword in %rax to octoword in %rdx:%rax";
        }
    }
}
