using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovz : BaseModel
    {
        public cmovz() :base("cmovz")
        {
            Comment = new Comment()
            {
                Start = "Move if equal / zero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
