using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setle : BaseModel
    {
        public setle(object? source, object? destination) :base("setle", source, destination)
        {
            Comment = $"Set if less or equal";
        }
    }
}
