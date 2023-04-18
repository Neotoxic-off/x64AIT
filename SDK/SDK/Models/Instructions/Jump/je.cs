using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class je : BaseModel
    {
        public je() :base("je")
        {
            Comment = new Comment()
            {
                Start = "Jump if equal / zero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
