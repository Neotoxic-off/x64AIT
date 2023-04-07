using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class shr : BaseModel<(UInt64 bits, object? destination)>
    {
        public shr() : base("shr", (0x00000000, null))
        {
            Comment = $"Logical right shift {Parameters.destination} by {Parameters.bits} bits";
        }
    }
}
