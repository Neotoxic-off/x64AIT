using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class sal : BaseModel<(UInt64 bits, object? destination)>
    {
        public sal(): base("sal", (0x00000000, null))
        {
            Comment = $"Left shift {Parameters.destination} by {Parameters.bits} bits";
        }
    }
}
