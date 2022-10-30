using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Supervisor : Employee
    {
        public Supervisor(string name)
        {
            this.name = name;
        }

        public string provideInfo()
        {
            return "Information from " + name;
        }
    }
}
