using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnbe : BaseModel
    {
        public setnbe(object? source, object? destination) :base("setnbe", source, destination)
        {
            Comment = $"Set if above (unsigned)";
        }
    }
}
