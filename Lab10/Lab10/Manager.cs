﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Manager : Employee
    {
        public Manager(string name)
        {
            this.name = name;
        }

        public Decision suggestedDecision()
        {
            return new Decision();
        }
    }
    
}
