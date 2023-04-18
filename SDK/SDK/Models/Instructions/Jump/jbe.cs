using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jbe : BaseModel
    {
        public jbe() :base("jbe")
        {
            Comment = new Comment()
            {
                Start = "Jump if below or equal (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
