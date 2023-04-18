using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    internal class jnle: BaseModel
    {
        public jnle() :base("jnle")
        {
            Comment = new Comment()
            {
                Start = "Jump if greater (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
