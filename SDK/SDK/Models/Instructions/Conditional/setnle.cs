using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnle : BaseModel
    {
        public setnle(object? source, object? destination) :base("setnle", source, destination)
        {
            Comment = $"Set if greater or equal (signed)";
        }
    }
}
