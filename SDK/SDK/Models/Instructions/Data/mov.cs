﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class mov: BaseModel<(object? source, object? destination)>
    {
        public mov() : base("mov", (null, null))
        {

        }
    }
}
