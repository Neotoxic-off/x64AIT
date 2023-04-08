using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cltq : BaseModel<(object? source, object? destination)>
    {
        public cltq() : base("cqto", (null, null))
        {
            Comment = $"Convert doubleword in %eax to quadword in %rax (sign-extended)";
        }
    }
}
