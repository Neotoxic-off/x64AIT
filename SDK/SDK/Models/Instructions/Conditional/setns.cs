using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setns : BaseModel
    {
        public setns(object? source, object? destination) :base("setns", source, destination)
        {
            Comment = $"Set if nonnegative";
        }
    }
}
