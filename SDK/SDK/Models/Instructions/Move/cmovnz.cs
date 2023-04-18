using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnz : BaseModel
    {
        public cmovnz() :base("cmovnz")
        {
            Comment = new Comment()
            {
                Start = "Move if not equal / nonzero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
