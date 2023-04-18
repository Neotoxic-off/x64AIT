using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class BaseModel
    {
        public string? Name { get; set; }
        public object? Source { get; set; }
        public object? Destination { get; set; }
        public Comment? Comment { get; set; }

        public BaseModel(string? Name)
        {
            this.Name = Name;
        }

        public void Render()
        {
            Comment.Render = string.Join(" ", new object?[] {
                Comment?.Start,
                Source,
                Comment?.Between,
                Destination,
                Comment?.End
            }.Where(s => !string.IsNullOrEmpty(s?.ToString())));
        }

        public BaseModel? Clone()
        {
            return ((BaseModel?)MemberwiseClone());
        }
    }
}
