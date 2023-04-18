using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class mulq : BaseModel
    {
        public mulq() :base("mulq")
        {
            Comment = new Comment()
            {
                Start = "Unsigned full multiply of %rax by",
                Between = "",
                End = ", result stored in %rdx:%rax",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
