using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnbe : BaseModel<(object? source, object? destination)>
    {
        public jnbe() : base("jnbe", (null, null))
        {
            Comment = $"Jump if above (unsigned)";
        }
    }
}
