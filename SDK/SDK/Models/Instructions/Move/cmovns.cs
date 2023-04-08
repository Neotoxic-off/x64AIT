using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovns : BaseModel
    {
        public cmovns(object? source, object? destination) :base("cmovns", source, destination)
        {
            Comment = $"Move if nonnegative";
        }
    }
}
