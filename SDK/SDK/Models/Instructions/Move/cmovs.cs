using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovs : BaseModel
    {
        public cmovs() :base("cmovs")
        {
            Comment = new Comment()
            {
                Start = "Move if negative",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
