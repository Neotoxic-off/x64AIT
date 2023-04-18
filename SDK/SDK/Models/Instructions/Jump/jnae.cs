using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnae : BaseModel
    {
        public jnae() :base("jnae")
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
