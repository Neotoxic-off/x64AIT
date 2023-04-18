using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnz : BaseModel
    {
        public setnz() :base("setnz")
        {
            Comment = new Comment()
            {
                Start = "Set if equal / zero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
