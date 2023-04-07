using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setle : BaseModel<UInt64>
    {
        public setle() : base("setle", 0x00000000)
        {
            Comment = $"Set if less or equal";
        }
    }
}
