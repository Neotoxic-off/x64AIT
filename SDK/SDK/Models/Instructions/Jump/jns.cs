using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jns : BaseModel
    {
        public jns() :base("jns")
        {
            Comment = new Comment()
            {
                Start = "Jump if nonnegative",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
