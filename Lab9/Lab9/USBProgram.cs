using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal abstract class USBProgram : CoffeeIF
    {
        public abstract void run();

        public void setCoffeeType(CoffeeIF cif)
        {

        }

        public double getPrice()
        {
            return 2.0;
        }
    }
}
