using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnb : BaseModel<object?>
    {
        public jnb() : base("jnb", null)
        {
            Comment = $"Jump if above or equal (unsigned)";
        }
    }
}
