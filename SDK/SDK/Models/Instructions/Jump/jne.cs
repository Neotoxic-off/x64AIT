using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jne : BaseModel<object?>
    {
        public jne() : base("jne", null)
        {
            Comment = $"Jump if not equal/nonzero";
        }
    }
}
