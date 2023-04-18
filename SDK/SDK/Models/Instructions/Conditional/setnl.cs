using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnl : BaseModel
    {
        public setnl() :base("setnl")
        {
            Comment = new Comment()
            {
                Start = "Set if less (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
