using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setna : BaseModel<UInt64>
    {
        public setna() : base("setna", 0x00000000)
        {
            Comment = $"Set if below or equal (unsigned)";
        }
    }
}
