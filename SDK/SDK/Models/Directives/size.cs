using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class size : BaseModel
    {
        public size() : base(".size")
        {
            this.Comment = "Declares the symbol size to be expr. expr must be an absolute expression.";
        }
    }
}

