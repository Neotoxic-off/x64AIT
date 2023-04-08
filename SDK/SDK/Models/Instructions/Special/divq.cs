using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class divq : BaseModel<(object? source, object? destination)>
    {
        public divq() : base("divq", (0x00000000, null))
        {
            Comment = $"Unsigned divide %rdx:%rax by {Parameters}, quotient stored in %rax, remainder stored in %rdx";
        }
    }
}
