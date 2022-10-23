/**
 * Jason Cross and Dominick Carlucci
 * Regular.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

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
        CMM cmm = new CMM();

        public void run()
        {
            cmm.setLEDNumber(10);

            cmm.setCoffeeType("Regular");

            cmm.setGrindingTime(4);

            cmm.setTemperature(135);

            cmm.setLEDNumber(0);

            cmm.done();
        }

        public double getPrice()
        {
            return basePrice;
        }
    }
}
