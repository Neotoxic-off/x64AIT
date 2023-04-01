using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setl : BaseModel<UInt64>
    {
        public setl() : base("setl", 0x00000000)
        {

        }
    }
}
