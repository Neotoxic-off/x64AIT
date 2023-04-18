using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class push: BaseModel
    {
        public push() : base("push")
        {
            Comment = new Comment()
            {
                Start = "Push",
                Between = "",
                End = "onto stack",
                Source = Source?.ToString(),
                Destination = ""
            };
        }
    }
}
