using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setna : BaseModel
    {
        public setna() :base("setna")
        {
            Comment = new Comment()
            {
                Start = "Set if below or equal (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
