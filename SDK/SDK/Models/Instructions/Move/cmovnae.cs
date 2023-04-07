using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnae : BaseModel<(object? source, object? destination)>
    {
        public cmovnae() : base("cmovnae", (null, null))
        {
            Comment = $"Move if below (unsigned)";
        }
    }
}
