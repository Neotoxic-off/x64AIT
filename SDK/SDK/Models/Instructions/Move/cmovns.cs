using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovns : BaseModel
    {
        public cmovns() :base("cmovns")
        {
            Comment = new Comment()
            {
                Start = "Move if nonnegative",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
