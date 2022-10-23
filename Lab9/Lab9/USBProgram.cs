using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal abstract class USBProgram : CoffeeIF
    {
        CoffeeIF cif;
        CondimentIF cdif;
        CMM cmm = new CMM();

        public abstract void run();        

        public double getPrice()
        {
            if (cdif == null)
            {
                return cif.getPrice();
            }
            else
            {
                return cif.getPrice() + cdif.getCharge();
            }
        }
    }
}
