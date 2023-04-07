using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class mov: BaseModel<(object? source, object? destination)>
    {
        private List<(object? source, object? destination, string comment)> map { get; set; }

        public mov() : base("mov", (null, null))
        {
            map = new List<(object? source, object? destination, string comment)>()
            {
                (Default, Default, $"Move {Parameters.source} to {Parameters.destination}"),
                (Default, null, $"Move byte to word (sign extended)")
            };

            Load();
        }

        private void Load()
        {
            foreach ((object? source, object? destination, string comment) data in map)
            {
                if (Parameters.source == data.source && Parameters.destination == data.destination)
                {
                    Comment = data.comment;
                }
            }
        }
    }
}
