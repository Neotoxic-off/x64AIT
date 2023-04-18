using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class not : BaseModel
    {
        public not() :base("not")
        {
            Comment = new Comment()
            {
                Start = "Bitwise complement",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
