﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnle : BaseModel<(object? source, object? destination)>
    {
        public cmovnle() : base("cmovnle", (null, null))
        {
            Comment = $"Move if greater (signed)";
        }
    }
}