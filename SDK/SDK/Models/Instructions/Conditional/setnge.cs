using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnge : BaseModel<UInt64>
    {
        public setnge() : base("setnge", 0x00000000)
        {

        }
    }
}
