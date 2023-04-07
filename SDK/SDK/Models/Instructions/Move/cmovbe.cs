using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovbe : BaseModel<(object? source, object? destination)>
    {
        public cmovbe() : base("cmovbe", (null, null))
        {
            Comment = $"Move if below or equal (unsigned)";
        }
    }
}
