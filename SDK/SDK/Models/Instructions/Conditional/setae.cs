using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setae : BaseModel
    {
        public setae() :base("setae")
        {
            Comment = new Comment()
            {
                Start = "Set if above or equal (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
