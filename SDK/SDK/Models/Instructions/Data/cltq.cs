using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cltq : BaseModel
    {
        public cltq(object? source, object? destination) :base("cqto", source, destination)
        {
            Comment = $"Convert doubleword in %eax to quadword in %rax (sign-extended)";
        }
    }
}
