using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmove : BaseModel
    {
        public cmove() :base("cmove")
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
