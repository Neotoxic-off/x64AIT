using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovbe : BaseModel
    {
        public cmovbe() :base("cmovbe")
        {
            Comment = new Comment()
            {
                Start = "Move if below or equal (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
