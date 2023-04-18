using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class dec : BaseModel
    {
        public dec() :base("dec")
        {
            Comment = new Comment()
            {
                Start = "Decrement",
                Between = "",
                End = "by 1",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
