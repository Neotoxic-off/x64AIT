using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setbe : BaseModel<(object? source, object? destination)>
    {
        public setbe() : base("setbe", (0x00000000, null))
        {
            Comment = $"Set if below or equal (unsigned)";
        }
    }
}
