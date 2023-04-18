using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Special
{
    public class imulq : BaseModel
    {
        public imulq() :base("imulq")
        {
            Comment = new Comment()
            {
                Start = "Signed full multiply of %rax by",
                Between = "",
                End = ", result stored in %rdx:%rax",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
