using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnl : BaseModel
    {
        public cmovnl() :base("cmovnl")
        {
            Comment = new Comment()
            {
                Start = "Move if greater or equal (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
