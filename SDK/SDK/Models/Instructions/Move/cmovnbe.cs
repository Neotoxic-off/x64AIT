using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnbe : BaseModel<(object? source, object? destination)>
    {
        public cmovnbe() : base("cmovnbe", (null, null))
        {
            Comment = $"Move if above (unsigned)";
        }
    }
}
