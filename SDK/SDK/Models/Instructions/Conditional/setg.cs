using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setg : BaseModel
    {
        public setg(object? source, object? destination) :base("setg", source, destination)
        {
            Comment = $"Set if greater (signed)";
        }
    }
}
