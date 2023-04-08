﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setge : BaseModel<(object? source, object? destination)>
    {
        public setge() : base("setge", (0x00000000, null))
        {
            Comment = $"Set if greater or equal (signed)";
        }
    }
}
