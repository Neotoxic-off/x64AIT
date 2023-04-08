using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class mulq : BaseModel
    {
        public mulq(object? source, object? destination) :base("mulq", source, destination)
        {
            Comment = $"Unsigned full multiply of %rax by {Source}, result stored in %rdx:%rax";
        }
    }
}
