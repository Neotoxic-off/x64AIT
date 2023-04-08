using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class and : BaseModel
    {
        public and(object? source, object? destination) : base("and", source, destination)
        {
            Comment = $"Bitwise AND {Destination} by {Source}";
        }
    }
}
