﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovne : BaseModel
    {
        public cmovne() :base("cmovne")
        {
            Comment = new Comment()
            {
                Start = "Move if not equal / nonzero",
                Between = "",
                End = "",
                Source = "",
                Destination = ""
            };
        }
    }
}
