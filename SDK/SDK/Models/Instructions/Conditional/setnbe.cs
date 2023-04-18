using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setnbe : BaseModel
    {
        public setnbe() :base("setnbe")
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
