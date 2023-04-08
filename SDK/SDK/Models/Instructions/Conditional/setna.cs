using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setna : BaseModel<(object? source, object? destination)>
    {
        public setna() : base("setna", (0x00000000, null))
        {
            Comment = $"Set if below or equal (unsigned)";
        }
    }
}
