using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class zero : BaseModel
    {
        public zero() : base(".zero")
        {
            this.Comment = "While filling a data section, the .zero directive fills the number of bytes specified by expression with zero (0).";
        }
    }
}

