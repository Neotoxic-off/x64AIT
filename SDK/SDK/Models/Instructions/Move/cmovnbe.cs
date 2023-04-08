using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnbe : BaseModel
    {
        public cmovnbe(object? source, object? destination) :base("cmovnbe", source, destination)
        {
            Comment = $"Move if above (unsigned)";
        }
    }
}
