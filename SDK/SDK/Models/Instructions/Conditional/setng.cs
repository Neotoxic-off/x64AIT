using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setng : BaseModel<UInt64>
    {
        public setng() : base("setng", 0x00000000)
        {

        }
    }
}
