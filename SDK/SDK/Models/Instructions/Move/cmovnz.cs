using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnz : BaseModel
    {
        public cmovnz(object? source, object? destination) :base("cmovnz", source, destination)
        {
            Comment = $"Move if not equal/nonzero";
        }
    }
}
