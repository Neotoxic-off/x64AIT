using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnbe : BaseModel
    {
        public jnbe(object? source, object? destination) :base("jnbe", source, destination)
        {
            Comment = $"Jump if above (unsigned)";
        }
    }
}
