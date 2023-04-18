﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class sets : BaseModel
    {
        public sets() :base("sets")
        {
            Comment = new Comment()
            {
                Start = "Set if nonnegative",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
