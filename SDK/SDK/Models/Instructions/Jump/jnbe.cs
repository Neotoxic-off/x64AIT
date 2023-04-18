using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnbe : BaseModel
    {
        public jnbe() :base("jnbe")
        {
            Comment = new Comment()
            {
                Start = "Jump if above (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
