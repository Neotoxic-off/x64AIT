using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class divq : BaseModel
    {
        public divq(object? source, object? destination) :base("divq", source, destination)
        {
            Comment = $"Unsigned divide %rdx:%rax by {Source}, quotient stored in %rax, remainder stored in %rdx";
        }
    }
}
