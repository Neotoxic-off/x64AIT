using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnb : BaseModel
    {
        public jnb(object? source, object? destination) :base("jnb", source, destination)
        {
            Comment = $"Jump if above or equal (unsigned)";
        }
    }
}
