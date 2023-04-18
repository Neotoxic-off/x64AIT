using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class or : BaseModel
    {
        public or() :base("or")
        {
            Comment = new Comment()
            {
                Start = "Load effective address of",
                Between = "into",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
