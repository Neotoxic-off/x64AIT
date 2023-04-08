using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class xor : BaseModel
    {
        public xor(object? source, object? destination) :base("xor", source, destination)
        {
            Comment = $"Bitwise XOR {Destination} by {Source}";
        }
    }
}
