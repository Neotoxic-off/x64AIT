using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setne : BaseModel
    {
        public setne(object? source, object? destination) :base("setne", source, destination)
        {
            Comment = $"Set if not equal/nonzero";
        }
    }
}
