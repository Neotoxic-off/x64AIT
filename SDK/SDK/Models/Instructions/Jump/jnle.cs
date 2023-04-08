using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    internal class jnle: BaseModel<(object? source, object? destination)>
    {
        public jnle() : base("jnle", (null, null))
        {
            Comment = $"Jump if greater (signed)";
        }
    }
}
