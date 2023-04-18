using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnge : BaseModel
    {
        public jnge() :base("jnge")
        {
            Comment = new Comment()
            {
                Start = "Jump if less (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
