using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class sar : BaseModel<(UInt64 bits, object? destination)>
    {
        public sar() : base("sar", (0x00000000, null))
        {

        }
    }
}
