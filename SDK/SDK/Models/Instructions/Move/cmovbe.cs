using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovbe : BaseModel
    {
        public cmovbe(object? source, object? destination) :base("cmovbe", source, destination)
        {
            Comment = $"Move if below or equal (unsigned)";
        }
    }
}
