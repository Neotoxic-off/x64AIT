using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jg : BaseModel
    {
        public jg(object? source, object? destination) :base("jg", source, destination)
        {
            Comment = $"Jump if greater (signed)";
        }
    }
}
