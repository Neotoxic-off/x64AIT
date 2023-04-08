using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class inc : BaseModel
    {
        public inc(object? source, object? destination) :base("inc", source, destination)
        {
            Comment = $"Increment {Source} by 1";
        }
    }
}
