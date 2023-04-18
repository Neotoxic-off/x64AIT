using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovna : BaseModel
    {
        public cmovna() :base("cmovna")
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
