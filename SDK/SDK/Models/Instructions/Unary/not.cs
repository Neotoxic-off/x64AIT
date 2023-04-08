using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class not : BaseModel<(object? source, object? destination)>
    {
        public not() : base("not", (0x00000000, null))
        {
            Comment = $"Bitwise complement";
        }
    }
}
