using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovna : BaseModel<(object? source, object? destination)>
    {
        public cmovna() : base("cmovna", (null, null))
        {
            Comment = $"Move if below (unsigned)";
        }
    }
}
