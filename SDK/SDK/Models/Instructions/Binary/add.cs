using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class add : BaseModel
    {
        public add(object? source, object? destination) : base("add", source, destination)
        {
            Comment = $"Add {Source} to {Destination}";
        }
    }
}
