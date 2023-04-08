using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class sal : BaseModel
    {
        public sal(object? source, object? destination) : base("sal", source, destination)
        {
            Comment = $"Left shift {Destination} by {Source} bits";
        }
    }
}
