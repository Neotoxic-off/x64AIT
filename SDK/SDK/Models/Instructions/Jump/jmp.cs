using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jmp : BaseModel
    {
        public jmp() :base("jmp")
        {
            Comment = new Comment()
            {
                Start = "Jump to label / specified location",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
