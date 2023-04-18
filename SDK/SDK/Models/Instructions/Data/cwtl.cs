using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cwtl: BaseModel
    {
        public cwtl() :base("cwtl")
        {
            Comment = new Comment()
            {
                Start = "Convert word in %ax to doubleword in %eax (sign-extended)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
