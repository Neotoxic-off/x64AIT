using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovng : BaseModel
    {
        public cmovng() :base("cmovng")
        {
            Comment = new Comment()
            {
                Start = "Move if less (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
