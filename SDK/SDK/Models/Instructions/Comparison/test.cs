using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Comparison
{
    public class test : BaseModel
    {
        public test(object? source, object? destination) :base("test", source, destination)
        {
            Comment = $"Set condition codes according to {Source} & {Destination}";
        }
    }
}
