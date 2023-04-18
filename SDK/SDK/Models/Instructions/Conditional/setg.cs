using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setg : BaseModel
    {
        public setg() :base("setg")
        {
            Comment = new Comment()
            {
                Start = "Set if greater (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
