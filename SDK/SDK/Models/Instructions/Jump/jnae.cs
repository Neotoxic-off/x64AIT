﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnae : BaseModel<object?>
    {
        public jnae() : base("jnae", null)
        {
            Comment = $"Jump if below (unsigned)";
        }
    }
}
