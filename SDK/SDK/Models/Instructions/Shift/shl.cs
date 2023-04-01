using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class shl : BaseModel<(UInt64 bits, object? destination)>
    {
        public shl() : base("shl", (0x00000000, null))
        {

        }
    }
}
