using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class ja : BaseModel
    {
        public ja() :base("ja")
        {
            Comment = new Comment()
            {
                Start = "Jump if above (unsigned)",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
