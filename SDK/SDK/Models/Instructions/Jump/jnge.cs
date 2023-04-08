using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnge : BaseModel<(object? source, object? destination)>
    {
        public jnge() : base("jnge", (null, null))
        {
            Comment = $"Jump if less (signed)";
        }
    }
}
