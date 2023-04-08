using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class seta : BaseModel<(UInt64 source, object? destination)>
    {
        public seta() : base("seta", (0x00000000, null))
        {
            Comment = $"Set if above (unsigned)";
        }
    }
}
