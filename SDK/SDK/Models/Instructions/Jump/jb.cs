using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jb : BaseModel
    {
        public jb(object? source, object? destination) :base("jb", source, destination)
        {
            Comment = $"Jump if below (unsigned)";
        }
    }
}
