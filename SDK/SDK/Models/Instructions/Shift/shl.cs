using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class shl : BaseModel
    {
        public shl(object? source, object? destination) :base("shl", source, destination)
        {
            Comment = $"Left shift {Destination} by {Source} bits";
        }
    }
}
