using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setae : BaseModel<(object? source, object? destination)>
    {
        public setae() : base("setae", (0x00000000, null))
        {
            Comment = $"Set if above or equal (unsigned)";
        }
    }
}
