using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class imulq : BaseModel
    {
        public imulq(object? source, object? destination) :base("imulq", source, destination)
        {
            Comment = $"Signed full multiply of %rax by {Source}, result stored in %rdx:%rax";
        }
    }
}
