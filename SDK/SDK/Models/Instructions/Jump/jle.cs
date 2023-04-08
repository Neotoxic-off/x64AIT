using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jle : BaseModel
    {
        public jle(object? source, object? destination) :base("jle", source, destination)
        {
            Comment = $"Jump if less or equal";
        }
    }
}
