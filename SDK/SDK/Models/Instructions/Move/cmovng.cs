using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovng : BaseModel
    {
        public cmovng(object? source, object? destination) :base("cmovng", source, destination)
        {
            Comment = $"Move if less (signed)";
        }
    }
}
