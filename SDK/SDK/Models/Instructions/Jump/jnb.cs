using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnb : BaseModel
    {
        public jnb() :base("jnb")
        {
            Comment = new Comment()
            {
                Start = "Jump if above or equal (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
