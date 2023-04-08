using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnbe : BaseModel<(object? source, object? destination)>
    {
        public setnbe() : base("setnbe", (0x00000000, null))
        {
            Comment = $"Set if above (unsigned)";
        }
    }
}
