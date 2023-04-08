using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnae : BaseModel<(object? source, object? destination)>
    {
        public setnae() : base("setnae", (0x00000000, null))
        {
            Comment = $"Set if below (unsigned)";
        }
    }
}
