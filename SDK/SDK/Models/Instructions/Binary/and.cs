using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class and : BaseModel<(object? source, object? destination)>
    {
        public and() : base("and", (null, null))
        {
            Comment = $"Bitwise AND {Parameters.destination} by {Parameters.source}";
        }
    }
}
