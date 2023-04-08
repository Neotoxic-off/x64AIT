using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setl : BaseModel
    {
        public setl(object? source, object? destination) :base("setl", source, destination)
        {
            Comment = $"Set if less (signed)";
        }
    }
}
