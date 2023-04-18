﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class imul : BaseModel
    {
        public imul() : base("imul")
        {
            Comment = new Comment()
            {
                Start = "Multiply",
                Between = "by",
                End = "",
                Source = Source?.ToString(),
                Destination = Destination?.ToString()
            };
        }
    }
}
