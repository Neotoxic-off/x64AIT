using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnle : BaseModel
    {
        public cmovnle() :base("cmovnle")
        {
            Comment = new Comment()
            {
                Start = "Move if greater (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
