using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnae : BaseModel
    {
        public jnae(object? source, object? destination) :base("jnae", source, destination)
        {
            Comment = $"Jump if below (unsigned)";
        }
    }
}
