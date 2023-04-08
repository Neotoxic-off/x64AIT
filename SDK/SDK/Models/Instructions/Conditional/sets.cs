using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class sets : BaseModel
    {
        public sets(object? source, object? destination) :base("sets", source, destination)
        {
            Comment = $"Set if nonnegative";
        }
    }
}
