using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class leave : BaseModel
    {
        public leave(object? source, object? destination) :base("leave", source, destination)
        {
            Comment = $"Set %rsp to %rbp, then pop top of stack into %rbp";
        }
    }
}
