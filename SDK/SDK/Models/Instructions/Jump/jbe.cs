﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jbe : BaseModel<object?>
    {
        public jbe() : base("jbe", null)
        {
            Comment = $"Jump if below or equal (unsigned)";
        }
    }
}