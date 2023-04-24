using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class uleb128 : BaseModel
    {
        public uleb128() : base(".uleb128")
        {
            this.Comment = "The .uleb128 directive generates an unsigned, little-endian, base 128 number from expression.";
        }
    }
}

