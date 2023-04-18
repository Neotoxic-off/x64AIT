using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jge : BaseModel
    {
        public jge() :base("jge")
        {
            Comment = new Comment()
            {
                Start = "Jump if greater or equal (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
