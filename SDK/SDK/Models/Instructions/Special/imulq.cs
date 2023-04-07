using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class imulq : BaseModel<UInt64>
    {
        public imulq() : base("imulq", 0x00000000)
        {
            Comment = $"Signed full multiply of %rax by {Parameters}, result stored in %rdx:%rax";
        }
    }
}
