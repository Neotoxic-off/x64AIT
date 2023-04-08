using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class seta : BaseModel
    {
        public seta(object? source, object? destination) :base("seta", source, destination)
        {
            Comment = $"Set if above (unsigned)";
        }
    }
}
