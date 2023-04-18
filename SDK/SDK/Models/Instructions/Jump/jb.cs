using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jb : BaseModel
    {
        public jb() :base("jb")
        {
            Comment = new Comment()
            {
                Start = "Jump if below (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
