using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cltq : BaseModel
    {
        public cltq() :base("cqto")
        {
            Comment = new Comment()
            {
                Start = "Convert doubleword in %eax to quadword in %rax (sign-extended)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
