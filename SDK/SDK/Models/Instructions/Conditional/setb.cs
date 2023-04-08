using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setb : BaseModel
    {
        public setb(object? source, object? destination) :base("setb", source, destination)
        {
            Comment = $"Set if below (unsigned)";
        }
    }
}
