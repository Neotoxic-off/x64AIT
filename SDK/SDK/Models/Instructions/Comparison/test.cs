using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Comparison
{
    public class test : BaseModel
    {
        public test() :base("test")
        {
            Comment = new Comment()
            {
                Start = "Set condition codes according to",
                Between = "&",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
