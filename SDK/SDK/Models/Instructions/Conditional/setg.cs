using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setg : BaseModel<UInt64>
    {
        public setg() : base("setg", 0x00000000)
        {
            Comment = $"Set if greater (signed)";
        }
    }
}
