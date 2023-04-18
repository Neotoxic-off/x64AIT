﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class js : BaseModel
    {
        public js() :base("js")
        {
            Comment = new Comment()
            {
                Start = "Jump if negative",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
