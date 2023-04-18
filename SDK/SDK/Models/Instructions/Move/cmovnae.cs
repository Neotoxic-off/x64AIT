using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnae : BaseModel
    {
        public cmovnae() :base("cmovnae")
        {
            Comment = new Comment()
            {
                Start = "Move if below (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
