using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class sets : BaseModel<UInt64>
    {
        public sets() : base("sets", 0x00000000)
        {

        }
    }
}
