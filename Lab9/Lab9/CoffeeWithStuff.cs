/**
 * Jason Cross and Dominick Carlucci
 * CoffeeWithStuff.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    // Wrapper/Decorator
    internal class CoffeeWithStuff : CoffeeIF
    {
        CoffeeIF cif;
        CondimentIF cdif;
        CMM cmm = new CMM();

        public CoffeeWithStuff(CoffeeIF cif, CondimentIF cdif)
        {
            this.cif = cif;
            this.cdif = cdif;
        }        

        public double getPrice()
        {
            return cif.getPrice() + cdif.getCharge();
        }

        public void run()
        {
            cif.run();
        }

        public double getCondPrice()
        {
            return cdif.getCharge();
        }
    }
}
