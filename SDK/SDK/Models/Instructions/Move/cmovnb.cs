using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnb : BaseModel
    {
        public cmovnb() :base("cmovnb")
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
