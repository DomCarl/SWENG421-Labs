using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Mocha: CoffeeIF
    {
        readonly double basePrice = 4.00;

        void run()
        {

        }

        public double getBasePrice()
        {
            return basePrice;
        }
    }
}
