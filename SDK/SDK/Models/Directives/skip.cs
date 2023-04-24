using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class skip : BaseModel
    {
        public skip() : base(".skip")
        {
            this.Comment = "While generating values for any data section, the .skip directive causes integer bytes to be skipped over, or, optionally, filled with the specified value.";
        }
    }
}

