using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class idivq : BaseModel<(object? source, object? destination)>
    {
        public idivq() : base("idivq", (0x00000000, null))
        {
            Comment = $"Signed divide %rdx:%rax by {Parameters}, quotient stored in %rax, remainder stored in %rdx";
        }
    }
}
