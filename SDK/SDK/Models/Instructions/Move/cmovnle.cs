using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnle : BaseModel
    {
        public cmovnle(object? source, object? destination) :base("cmovnle", source, destination)
        {
            Comment = $"Move if greater (signed)";
        }
    }
}
