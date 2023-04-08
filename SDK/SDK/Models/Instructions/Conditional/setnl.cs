using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnl : BaseModel
    {
        public setnl(object? source, object? destination) :base("setnl", source, destination)
        {
            Comment = $"Set if less (signed)";
        }
    }
}
