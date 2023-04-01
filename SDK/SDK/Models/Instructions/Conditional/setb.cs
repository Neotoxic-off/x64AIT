using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setb : BaseModel<UInt64>
    {
        public setb() : base("setb", 0x00000000)
        {

        }
    }
}
