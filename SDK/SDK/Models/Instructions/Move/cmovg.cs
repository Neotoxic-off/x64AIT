using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovg : BaseModel<(object? source, object? destination)>
    {
        public cmovg() : base("cmovg", (null, null))
        {
            Comment = $"Move if greater (signed)";
        }
    }
}
