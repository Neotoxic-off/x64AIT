using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class neg : BaseModel
    {
        public neg() :base("neg")
        {
            Comment = new Comment()
            {
                Start = "Arithmetic negation",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
