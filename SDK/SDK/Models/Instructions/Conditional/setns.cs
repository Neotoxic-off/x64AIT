using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setns : BaseModel<UInt64>
    {
        public setns() : base("setns", 0x00000000)
        {

        }
    }
}
