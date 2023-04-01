using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnb : BaseModel<UInt64>
    {
        public setnb() : base("setnb", 0x00000000)
        {

        }
    }
}
