﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class push: BaseModel<object?>
    {
        public push() : base("push", null)
        {
            Comment = $"Push {Parameters} onto stack";
        }
    }
}