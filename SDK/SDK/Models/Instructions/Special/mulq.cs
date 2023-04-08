using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class mulq : BaseModel<(object? source, object? destination)>
    {
        public mulq() : base("mulq", (0x00000000, null))
        {
            Comment = $"Unsigned full multiply of %rax by {Parameters}, result stored in %rdx:%rax";
        }
    }
}
