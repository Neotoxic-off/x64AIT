using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setge : BaseModel<UInt64>
    {
        public setge() : base("setge", 0x00000000)
        {
            Comment = $"Set if greater or equal (signed)";
        }
    }
}
