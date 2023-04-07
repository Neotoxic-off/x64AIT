﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnb : BaseModel<(object? source, object? destination)>
    {
        public cmovnb() : base("cmovnb", (null, null))
        {
            Comment = $"Move if above (unsigned)";
        }
    }
}