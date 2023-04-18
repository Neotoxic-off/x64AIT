using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class xor : BaseModel
    {
        public xor() :base("xor")
        {
            Comment = new Comment()
            {
                Start = "Bitwise XOR",
                Between = "by",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
