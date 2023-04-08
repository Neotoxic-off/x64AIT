using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovl : BaseModel
    {
        public cmovl(object? source, object? destination) :base("cmovl", source, destination)
        {
            Comment = $"Move if less (signed)";
        }
    }
}
