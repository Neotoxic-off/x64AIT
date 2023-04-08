using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class dec : BaseModel
    {
        public dec(object? source, object? destination) :base("dec", source, destination)
        {
            Comment = $"Decrement {Source} by 1";
        }
    }
}
