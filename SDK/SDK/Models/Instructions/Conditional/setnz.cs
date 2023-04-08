using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnz : BaseModel
    {
        public setnz(object? source, object? destination) :base("setnz", source, destination)
        {
            Comment = $"Set if equal/zero";
        }
    }
}
