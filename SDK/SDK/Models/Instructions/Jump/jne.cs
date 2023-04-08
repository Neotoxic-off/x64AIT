using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jne : BaseModel
    {
        public jne(object? source, object? destination) :base("jne", source, destination)
        {
            Comment = $"Jump if not equal/nonzero";
        }
    }
}
