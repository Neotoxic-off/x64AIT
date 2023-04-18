using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class sub : BaseModel
    {
        public sub() :base("sub")
        {
            Comment = new Comment()
            {
                Start = "Subtract",
                Between = "from",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
