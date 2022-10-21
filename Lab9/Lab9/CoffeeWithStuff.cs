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

        public CoffeeWithStuff(CoffeeIF cif, CondimentIF cdif)
        {
            this.cif = cif;
            this.cdif = cdif;
        }

        public double getBasePrice()
        {
            return cif.getBasePrice();
        }

        public double getPrice()
        {
            return cif.getBasePrice() + cdif.getCharge();
        }
    }
}
