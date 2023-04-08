using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class shr : BaseModel
    {
        public shr(object? source, object? destination) :base("shr", source, destination)
        {
            Comment = $"Logical right shift {Destination} by {Source} bits";
        }
    }
}
