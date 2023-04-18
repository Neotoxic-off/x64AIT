using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jle : BaseModel
    {
        public jle() :base("jle")
        {
            Comment = new Comment()
            {
                Start = "Jump if less or equal",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
