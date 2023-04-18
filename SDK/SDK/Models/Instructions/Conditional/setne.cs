using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setne : BaseModel
    {
        public setne() :base("setne")
        {
            Comment = new Comment()
            {
                Start = "Set if not equal / nonzero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
