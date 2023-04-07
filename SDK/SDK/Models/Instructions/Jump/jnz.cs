using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnz : BaseModel<object?>
    {
        public jnz() : base("jnz", null)
        {
            Comment = $"Jump if not equal/nonzero";
        }
    }
}
