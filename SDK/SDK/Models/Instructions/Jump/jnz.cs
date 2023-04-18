using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnz : BaseModel
    {
        public jnz() :base("jnz")
        {
            Comment = new Comment()
            {
                Start = "Jump if not equal/nonzero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
