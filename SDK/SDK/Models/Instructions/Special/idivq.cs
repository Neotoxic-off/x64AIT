using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class idivq : BaseModel
    {
        public idivq() :base("idivq")
        {
            Comment = new Comment()
            {
                Start = "Signed divide %rdx:%rax by",
                Between = "",
                End = ", quotient stored in %rax, remainder stored in %rdx",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
