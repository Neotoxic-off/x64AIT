using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class sleb128 : BaseModel
    {
        public sleb128() : base(".sleb128")
        {
            this.Comment = "The .sleb128 directive generates a signed, little-endian, base 128 number from expression.";
        }
    }
}

