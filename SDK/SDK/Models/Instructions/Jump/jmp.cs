using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jmp : BaseModel
    {
        public jmp(object? source, object? destination) :base("jmp", source, destination)
        {
            Comment = $"Jump to label/specified location";
        }
    }
}
