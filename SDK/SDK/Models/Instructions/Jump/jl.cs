using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jl : BaseModel<object?>
    {
        public jl() : base("jl", null)
        {
            Comment = $"Jump if less (signed)";
        }
    }
}
