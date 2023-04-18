using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class leave : BaseModel
    {
        public leave() :base("leave")
        {
            Comment = new Comment()
            {
                Start = "Set %rsp to %rbp, then pop top of stack into %rbp",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
