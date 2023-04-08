using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnle : BaseModel<(object? source, object? destination)>
    {
        public setnle() : base("setnle", (0x00000000, null))
        {
            Comment = $"Set if greater or equal (signed)";
        }
    }
}
