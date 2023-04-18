using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Comparison
{
    public class cmp : BaseModel
    {
        public cmp() :base("cmp")
        {
            Comment = new Comment()
            {
                Start = "Set condition codes according to",
                Between = "-",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
