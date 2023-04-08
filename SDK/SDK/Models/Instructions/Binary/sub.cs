using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class sub : BaseModel
    {
        public sub(object? source, object? destination) :base("sub", source, destination)
        {
            Comment = $"Subtract {Source} from {Destination}";
        }
    }
}
