using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    internal class jnle: BaseModel
    {
        public jnle(object? source, object? destination) :base("jnle", source, destination)
        {
            Comment = $"Jump if greater (signed)";
        }
    }
}
