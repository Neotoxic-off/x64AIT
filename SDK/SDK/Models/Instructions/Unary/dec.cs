using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class dec : BaseModel<(object? source, object? destination)>
    {
        public dec() : base("dec", (0x00000000, null))
        {
            Comment = $"Decrement {Parameters} by 1";
        }
    }
}
