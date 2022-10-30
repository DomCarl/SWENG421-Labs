using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class CEO : Employee
    {

        public Decision grant(Decision[] da)
        {
            return da[0];
        }
    }
}
