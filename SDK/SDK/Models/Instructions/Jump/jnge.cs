using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnge : BaseModel
    {
        public jnge(object? source, object? destination) :base("jnge", source, destination)
        {
            Comment = $"Jump if less (signed)";
        }
    }
}
