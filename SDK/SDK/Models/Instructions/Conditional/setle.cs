using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setle : BaseModel
    {
        public setle() :base("setle")
        {
            Comment = new Comment()
            {
                Start = "Set if less or equal",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
