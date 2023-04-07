using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class not : BaseModel<UInt64>
    {
        public not() : base("not", 0x00000000)
        {
            Comment = $"Bitwise complement";
        }
    }
}
