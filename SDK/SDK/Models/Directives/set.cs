using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class set : BaseModel
    {
        public set() : base(".set")
        {
            this.Comment = "The .set directive assigns the value of expression to symbol. Expression can be any legal expression that evaluates to a numerical value.";
        }
    }
}

