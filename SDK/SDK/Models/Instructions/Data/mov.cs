using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class mov: BaseModel
    {
        public mov() : base("mov")
        {
            Comment = new Comment()
            {
                Start = "Move",
                Between = "to",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
