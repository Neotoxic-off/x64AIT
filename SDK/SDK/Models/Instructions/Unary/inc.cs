using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class inc : BaseModel
    {
        public inc() :base("inc")
        {
            Comment = new Comment()
            {
                Start = "Increment",
                Between = "",
                End = "by 1",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
