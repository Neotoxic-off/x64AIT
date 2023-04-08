using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setge : BaseModel
    {
        public setge(object? source, object? destination) :base("setge", source, destination)
        {
            Comment = $"Set if greater or equal (signed)";
        }
    }
}
