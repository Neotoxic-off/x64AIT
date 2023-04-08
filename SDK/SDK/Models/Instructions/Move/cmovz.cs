using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovz : BaseModel
    {
        public cmovz(object? source, object? destination) :base("cmovz", source, destination)
        {
            Comment = $"Move if equal/zero";
        }
    }
}
