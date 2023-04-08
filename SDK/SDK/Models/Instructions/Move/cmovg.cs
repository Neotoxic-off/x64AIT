using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovg : BaseModel
    {
        public cmovg(object? source, object? destination) :base("cmovg", source, destination)
        {
            Comment = $"Move if greater (signed)";
        }
    }
}
