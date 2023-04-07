using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnl : BaseModel<object?>
    {
        public jnl() : base("jnl", null)
        {
            Comment = $"Jump if greater or equal (signed)";
        }
    }
}
