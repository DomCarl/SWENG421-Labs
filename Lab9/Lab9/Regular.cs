using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Regular: CoffeeIF
    {
        readonly double basePrice = 2.00;

        void run()
        {

        }

        public double getBasePrice()
        {
            return basePrice;
        }
    }
}
