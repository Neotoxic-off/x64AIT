using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class and : BaseModel
    {
        public and() : base("and")
        {
            Comment = new Comment()
            {
                Start = "Bitwise AND",
                Between = "by",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
