using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Shift
{
    public class sal : BaseModel
    {
        public sal() : base("sal")
        {
            Comment = new Comment()
            {
                Start = "Arithmetic left shift",
                Between = "by",
                End = "bits",
                Source = Destination?.ToString(),
                Destination = Source?.ToString()
            };
        }
    }
}
