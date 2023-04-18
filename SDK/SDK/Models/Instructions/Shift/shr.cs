using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class shr : BaseModel
    {
        public shr() :base("shr")
        {
            Comment = new Comment()
            {
                Start = "Logical right shift",
                Between = "by",
                End = "bits",
                Source = Destination?.ToString(),
                Destination = Source?.ToString()
            };
        }
    }
}
