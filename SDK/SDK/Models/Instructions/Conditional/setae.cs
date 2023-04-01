using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setae : BaseModel<UInt64>
    {
        public setae() : base("setae", 0x00000000)
        {

        }
    }
}
