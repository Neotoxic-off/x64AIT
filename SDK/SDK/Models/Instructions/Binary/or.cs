using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class or : BaseModel
    {
        public or(object? source, object? destination) :base("or", source, destination)
        {
            Comment = $"Bitwise OR {Destination} by {Source}";
        }
    }
}
