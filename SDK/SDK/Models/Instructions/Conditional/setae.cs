using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setae : BaseModel
    {
        public setae(object? source, object? destination) :base("setae", source, destination)
        {
            Comment = $"Set if above or equal (unsigned)";
        }
    }
}
