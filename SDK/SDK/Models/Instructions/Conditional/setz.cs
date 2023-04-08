using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setz : BaseModel
    {
        public setz(object? source, object? destination) :base("setz", source, destination)
        {
            Comment = $"Set if equal/zero";
        }
    }
}
