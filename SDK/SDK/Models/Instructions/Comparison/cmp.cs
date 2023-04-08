using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Comparison
{
    public class cmp : BaseModel
    {
        public cmp(object? source, object? destination) :base("cmp", source, destination)
        {
            Comment = $"Set condition codes according to {Source} - {Destination}";
        }
    }
}
