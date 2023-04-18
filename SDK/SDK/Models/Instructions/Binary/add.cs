using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class add : BaseModel
    {
        public add() : base("add")
        {
            Comment = new Comment()
            {
                Start = "Add",
                Between = "to",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
