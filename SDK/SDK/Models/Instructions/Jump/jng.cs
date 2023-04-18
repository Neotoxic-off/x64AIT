using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jng : BaseModel
    {
        public jng() :base("jng")
        {
            Comment = new Comment()
            {
                Start = "Jump if less or equal",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
