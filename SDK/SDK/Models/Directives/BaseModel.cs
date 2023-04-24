using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class BaseModel
    {
        public string? Name { get; set; }
        public string? Comment { get; set; }

        public BaseModel(string? Name)
        {
            this.Name = Name;
        }
    }
}
