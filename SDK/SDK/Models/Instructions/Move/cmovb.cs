using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovb : BaseModel
    {
        public cmovb(object? source, object? destination) :base("cmovb", source, destination)
        {
            Comment = $"Move if below (unsigned)";
        }
    }
}
