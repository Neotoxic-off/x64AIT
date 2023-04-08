using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnae : BaseModel
    {
        public setnae(object? source, object? destination) :base("setnae", source, destination)
        {
            Comment = $"Set if below (unsigned)";
        }
    }
}
