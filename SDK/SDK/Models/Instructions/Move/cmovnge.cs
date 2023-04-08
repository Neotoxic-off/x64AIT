using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnge : BaseModel
    {
        public cmovnge(object? source, object? destination) :base("cmovnge", source, destination)
        {
            Comment = $"Move if less (signed)";
        }
    }
}
