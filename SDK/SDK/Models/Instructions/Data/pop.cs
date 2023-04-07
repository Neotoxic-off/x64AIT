﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class pop: BaseModel<object?>
    {
        public pop() : base("pop", null)
        {
            Comment = $"Pop top of stack into {Parameters}";
        }
    }
}
