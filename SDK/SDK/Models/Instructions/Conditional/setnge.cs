using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnge : BaseModel
    {
        public setnge(object? source, object? destination) :base("setnge", source, destination)
        {
            Comment = $"Set if less (signed)";
        }
    }
}
