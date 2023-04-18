using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cqto : BaseModel
    {
        public cqto() :base("cqto")
        {
            Comment = new Comment()
            {
                Start = "Convert quadword in %rax to octoword in %rdx:%rax",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
