using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class pop: BaseModel
    {
        public pop() :base("pop")
        {
            Comment = new Comment()
            {
                Start = "Pop top of stack into",
                Between = "",
                End = "",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
