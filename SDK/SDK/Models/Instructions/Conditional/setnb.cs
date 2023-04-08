using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnb : BaseModel
    {
        public setnb(object? source, object? destination) :base("setnb", source, destination)
        {
            Comment = $"Set if above or equal (unsigned)";
        }
    }
}
