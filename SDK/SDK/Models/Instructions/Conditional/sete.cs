using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class sete : BaseModel
    {
        public sete(object? source, object? destination) :base("sete", source, destination)
        {
            Comment = $"Set if equal/zero";
        }
    }
}
