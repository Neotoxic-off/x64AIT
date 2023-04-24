using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class section : BaseModel
    {
        public section() : base(".section")
        {
            this.Comment = "The .section directive makes section the current section. If section does not exist, a new section with the specified name and attributes is created. If section is a non-reserved section, attributes must be included the first time section is specified by the .section directive.";
        }
    }
}

