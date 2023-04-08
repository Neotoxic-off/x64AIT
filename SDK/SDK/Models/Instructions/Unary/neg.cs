using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class neg : BaseModel<(object? source, object? destination)>
    {
        public neg() : base("neg", (0x00000000, null))
        {
            Comment = $"Arithmetic negation";
        }
    }
}
