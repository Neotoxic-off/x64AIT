using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class ret : BaseModel
    {
        public ret() :base("ret")
        {
            Comment = new Comment()
            {
                Start = "Pop return address from stack and jump there",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
