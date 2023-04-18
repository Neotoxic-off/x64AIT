using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class lea : BaseModel
    {
        public lea() :base("lea")
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
