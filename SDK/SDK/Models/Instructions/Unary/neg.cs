using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class neg : BaseModel<UInt64>
    {
        public neg() : base("neg", 0x00000000)
        {

        }
    }
}
