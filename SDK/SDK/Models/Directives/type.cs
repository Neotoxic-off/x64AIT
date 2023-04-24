using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class type : BaseModel
    {
        public type() : base(".type")
        {
            this.Comment = "Declares the type of symbol, where type can be: [#object  #tls_object  #function  #no_type ] and where visibility can be one of: [#hidden  #protected  #eliminate  #singleton  #exported  #internal]";
        }
    }
}

