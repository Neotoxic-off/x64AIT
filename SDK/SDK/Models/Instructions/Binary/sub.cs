using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class sub : BaseModel<(object? source, object? destination)>
    {
        public sub() : base("sub", (null, null))
        {
            Comment = $"Subtract {Parameters.source} from {Parameters.destination}";
        }
    }
}
