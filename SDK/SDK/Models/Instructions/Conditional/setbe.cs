using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setbe : BaseModel
    {
        public setbe(object? source, object? destination) :base("setbe", source, destination)
        {
            Comment = $"Set if below or equal (unsigned)";
        }
    }
}
