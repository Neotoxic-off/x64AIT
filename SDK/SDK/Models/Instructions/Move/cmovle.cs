using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovle : BaseModel
    {
        public cmovle() :base("cmovle")
        {
            Comment = new Comment()
            {
                Start = "Move if less or equal",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
