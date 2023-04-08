using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class imulq : BaseModel<(object? source, object? destination)>
    {
        public imulq() : base("imulq", (0x00000000, null))
        {
            Comment = $"Signed full multiply of %rax by {Parameters}, result stored in %rdx:%rax";
        }
    }
}
