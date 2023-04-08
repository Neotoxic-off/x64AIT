using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jge : BaseModel
    {
        public jge(object? source, object? destination) :base("jge", source, destination)
        {
            Comment = $"Jump if greater or equal (signed)";
        }
    }
}
