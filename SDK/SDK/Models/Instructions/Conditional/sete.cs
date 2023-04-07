using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class sete : BaseModel<UInt64>
    {
        public sete() : base("sete", 0x00000000)
        {
            Comment = $"Set if equal/zero";
        }
    }
}
