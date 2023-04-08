using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models
{
    public class BaseModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        private object? _source;
        public object? Source
        {
            get { return _source; }
            set { SetProperty(ref _source, value); }
        }
        private object? _destination;
        public object? Destination
        {
            get { return _destination; }
            set { SetProperty(ref _destination, value); }
        }
        private string _comment;
        public virtual string Comment
        {
            get { return _comment; }
            set { SetProperty(ref _comment, value); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private static string PlaceHolderSource = "EMPTY_SOURCE";
        private static string PlaceHolderDestination = "EMPTY_DESTINATION";

        public BaseModel(string Name, object? Source, object? Destination)
        {
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
        }

        public void Render()
        {
            this.Comment = Comment.Replace(PlaceHolderSource, $"{Source}").Replace(PlaceHolderDestination, $"{Destination}");
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue) == false)
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

                return (true);
            }
            return (false);
        }
    }
}
