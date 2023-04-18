using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setz : BaseModel
    {
        public setz() :base("setz")
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
