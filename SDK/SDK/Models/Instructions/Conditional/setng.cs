using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setng : BaseModel
    {
        public setng(object? source, object? destination) :base("setng", source, destination)
        {
            Comment = $"Set if less or equal";
        }
    }
}
