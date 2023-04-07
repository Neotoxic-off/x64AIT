using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovng : BaseModel<(object? source, object? destination)>
    {
        public cmovng() : base("cmovng", (null, null))
        {
            Comment = $"Move if less (signed)";
        }
    }
}
