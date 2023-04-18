using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnl : BaseModel
    {
        public jnl() :base("jnl")
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
