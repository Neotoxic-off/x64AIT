using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setne : BaseModel<UInt64>
    {
        public setne() : base("setne", 0x00000000)
        {
            Comment = $"Set if not equal/nonzero";
        }
    }
}
