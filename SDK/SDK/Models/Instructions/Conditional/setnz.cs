using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnz : BaseModel<UInt64>
    {
        public setnz() : base("setnz", 0x00000000)
        {

        }
    }
}
