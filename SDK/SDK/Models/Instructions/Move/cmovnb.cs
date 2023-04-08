using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnb : BaseModel
    {
        public cmovnb(object? source, object? destination) :base("cmovnb", source, destination)
        {
            Comment = $"Move if above (unsigned)";
        }
    }
}
