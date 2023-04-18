using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jne : BaseModel
    {
        public jne() :base("jne")
        {
            Comment = new Comment()
            {
                Start = "Jump if not equal / nonzero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
