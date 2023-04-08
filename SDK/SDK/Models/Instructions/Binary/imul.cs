using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class imul : BaseModel
    {
        public imul(object? source, object? destination) : base("imul", source, destination)
        {
            Comment = $"Multiply {Destination} by {Source}";
        }
    }
}
