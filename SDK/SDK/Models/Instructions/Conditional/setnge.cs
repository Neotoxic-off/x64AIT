using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnge : BaseModel<(object? source, object? destination)>
    {
        public setnge() : base("setnge", (0x00000000, null))
        {
            Comment = $"Set if less (signed)";
        }
    }
}
