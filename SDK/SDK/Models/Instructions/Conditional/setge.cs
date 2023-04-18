using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setge : BaseModel
    {
        public setge() :base("setge")
        {
            Comment = new Comment()
            {
                Start = "Set if greater or equal (signed)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
