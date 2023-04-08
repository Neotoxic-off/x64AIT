using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnl : BaseModel
    {
        public jnl(object? source, object? destination) :base("jnl", source, destination)
        {
            Comment = $"Jump if greater or equal (signed)";
        }
    }
}
