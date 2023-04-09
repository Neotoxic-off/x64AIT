using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Registers
{
    public class BaseModel
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public BaseModel(string Name, int Size)
        {
            this.Name = Name;
            this.Size = Size;
        }
    }
}
