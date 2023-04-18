using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class seta : BaseModel
    {
        public seta() :base("seta")
        {
            Comment = new Comment()
            {
                Start = "Set if above (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
