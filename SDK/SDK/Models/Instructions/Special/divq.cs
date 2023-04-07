using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class divq : BaseModel<UInt64>
    {
        public divq() : base("divq", 0x00000000)
        {
            Comment = $"Unsigned divide %rdx:%rax by {Parameters}, quotient stored in %rax, remainder stored in %rdx";
        }
    }
}
