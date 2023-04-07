using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models
{
    public class BaseModel<T>
    {
        public string Name { get; set; }
        public T Parameters { get; set; }
        public virtual string Comment { get; set; }
        public object? Default { get; set; }

        public BaseModel(string Name, T Parameters)
        {
            this.Default = string.Empty;
            this.Name = Name;
            this.Parameters = Parameters;
        }
    }
}
