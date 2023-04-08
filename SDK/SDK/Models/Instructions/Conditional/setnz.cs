using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnz : BaseModel<(object? source, object? destination)>
    {
        public setnz() : base("setnz", (0x00000000, null))
        {
            Comment = $"Set if equal/zero";
        }
    }
}
