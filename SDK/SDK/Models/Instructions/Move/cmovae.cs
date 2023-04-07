using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovae : BaseModel<(object? source, object? destination)>
    {
        public cmovae() : base("cmovae", (null, null))
        {
            Comment = $"Move if above or equal (unsigned)";
        }
    }
}
