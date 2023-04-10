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
        public string Name { get; set; }
        public object? Source { get; set; }
        public object? Destination { get; set; }
        public string Comment { get; set; }
        public static string PlaceHolderSource = "EMPTY_SOURCE";
        public static string PlaceHolderDestination = "EMPTY_DESTINATION";

        public BaseModel(string Name, object? Source, object? Destination)
        {
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
        }

        public void Render()
        {
            List<(string placeholder, object? param)> items = new List<(string placeholder, object? param)>()
            {
                (PlaceHolderSource, Source),
                (PlaceHolderDestination, Destination)
            };

            foreach ((string placeholder, object? param) item in items)
            {
                if (item.param != null)
                {
                    Comment = Comment.Replace(item.placeholder, $"{item.param}");
                }
            }
        }

        public BaseModel? Clone()
        {
            return ((BaseModel?)MemberwiseClone());
        }
    }
}
