using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class sar : BaseModel
    {
        public sar(object? source, object? destination) :base("sar", source, destination)
        {
            Comment = $"Arithmetic right shift {Destination} by {Source} bits";
        }
    }
}
