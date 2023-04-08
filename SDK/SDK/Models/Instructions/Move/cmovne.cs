using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovne : BaseModel
    {
        public cmovne(object? source, object? destination) :base("cmovne", source, destination)
        {
            Comment = $"Move if not equal/nonzero";
        }
    }
}
