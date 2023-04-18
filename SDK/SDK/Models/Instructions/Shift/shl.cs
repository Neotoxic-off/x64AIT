using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class shl : BaseModel
    {
        public shl() :base("shl")
        {
            Comment = new Comment()
            {
                Start = "Logical left shift",
                Between = "by",
                End = "bits",
                Source = Destination?.ToString(),
                Destination = Source?.ToString()
            };
        }
    }
}
