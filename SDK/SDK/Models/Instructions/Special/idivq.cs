using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class idivq : BaseModel
    {
        public idivq(object? source, object? destination) :base("idivq", source, destination)
        {
            Comment = $"Signed divide %rdx:%rax by {Source}, quotient stored in %rax, remainder stored in %rdx";
        }
    }
}
