using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmove : BaseModel
    {
        public cmove(object? source, object? destination) :base("cmove", source, destination)
        {
            Comment = $"Move if equal/zero";
        }
    }
}
