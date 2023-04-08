using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class leave : BaseModel<(object? source, object? destination)>
    {
        public leave() : base("leave", (null, null))
        {
            Comment = $"Set %rsp to %rbp, then pop top of stack into %rbp";
        }
    }
}
