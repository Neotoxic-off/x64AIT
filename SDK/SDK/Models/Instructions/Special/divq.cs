using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class divq : BaseModel
    {
        public divq() :base("divq")
        {
            Comment = new Comment()
            {
                Start = "Unsigned divide %rdx:%rax by",
                Between = "",
                End = ", quotient stored in %rax, remainder stored in %rdx",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
