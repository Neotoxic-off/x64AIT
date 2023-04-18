using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovae : BaseModel
    {
        public cmovae() :base("cmovae")
        {
            Comment = new Comment()
            {
                Start = "Move if above or equal (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
