using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnl : BaseModel
    {
        public cmovnl(object? source, object? destination) :base("cmovnl", source, destination)
        {
            Comment = $"Move if greater or equal (signed)";
        }
    }
}
