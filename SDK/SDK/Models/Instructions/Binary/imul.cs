using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class imul : BaseModel<(object? source, object? destination)>
    {
        public imul() : base("imul", (null, null))
        {
            Comment = $"Multiply {Parameters.destination} by {Parameters.source}";
        }
    }
}
