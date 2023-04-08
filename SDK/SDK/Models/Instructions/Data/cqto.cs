using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cqto : BaseModel<(object? source, object? destination)>
    {
        public cqto() : base("cqto", (null, null))
        {
            Comment = $"Convert quadword in %rax to octoword in %rdx:%rax";
        }
    }
}
