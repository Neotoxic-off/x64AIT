using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnbe : BaseModel
    {
        public cmovnbe() :base("cmovnbe")
        {
            Comment = new Comment()
            {
                Start = "Move if above (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
