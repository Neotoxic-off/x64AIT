using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnae : BaseModel
    {
        public setnae() :base("setnae")
        {
            Comment = new Comment()
            {
                Start = "Set if below (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
