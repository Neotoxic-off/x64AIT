using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jz : BaseModel
    {
        public jz(object? source, object? destination) :base("jz", source, destination)
        {
            Comment = $"Jump if equal/zero";
        }
    }
}
