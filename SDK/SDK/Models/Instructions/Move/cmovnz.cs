using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnz : BaseModel<(object? source, object? destination)>
    {
        public cmovnz() : base("cmovnz", (null, null))
        {
            Comment = $"Move if not equal/nonzero";
        }
    }
}
