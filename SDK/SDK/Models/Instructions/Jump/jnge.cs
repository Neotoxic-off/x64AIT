﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnge : BaseModel<object?>
    {
        public jnge() : base("jnge", null)
        {
            Comment = $"Jump if less (signed)";
        }
    }
}