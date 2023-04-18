using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class sar : BaseModel
    {
        public sar() :base("sar")
        {
            Comment = new Comment()
            {
                Start = "Arithmetic right shift",
                Between = "by",
                End = "bits",
                Source = Destination?.ToString(),
                Destination = Source?.ToString()
            };
        }
    }
}
