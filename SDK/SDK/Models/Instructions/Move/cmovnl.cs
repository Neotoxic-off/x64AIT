using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnl : BaseModel<(object? source, object? destination)>
    {
        public cmovnl() : base("cmovnl", (null, null))
        {
            Comment = $"Move if greater or equal (signed)";
        }
    }
}
