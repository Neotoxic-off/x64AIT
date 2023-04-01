using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class dec : BaseModel<UInt64>
    {
        public dec() : base("dec", 0x00000000)
        {

        }
    }
}
