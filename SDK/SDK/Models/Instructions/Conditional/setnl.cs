using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnl : BaseModel<UInt64>
    {
        public setnl() : base("setnl", 0x00000000)
        {

        }
    }
}
