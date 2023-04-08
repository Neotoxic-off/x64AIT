using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jl : BaseModel
    {
        public jl(object? source, object? destination) :base("jl", source, destination)
        {
            Comment = $"Jump if less (signed)";
        }
    }
}
