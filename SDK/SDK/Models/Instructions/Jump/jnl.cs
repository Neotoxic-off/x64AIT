using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnl : BaseModel<(object? source, object? destination)>
    {
        public jnl() : base("jnl", (null, null))
        {
            Comment = $"Jump if greater or equal (signed)";
        }
    }
}
