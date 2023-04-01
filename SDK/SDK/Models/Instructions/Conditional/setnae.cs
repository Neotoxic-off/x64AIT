using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnae : BaseModel<UInt64>
    {
        public setnae() : base("setnae", 0x00000000)
        {

        }
    }
}
