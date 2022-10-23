/**
 * Jason Cross and Dominick Carlucci
 * Cappuccino.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Cappuccino : CoffeeIF
    {
        readonly double basePrice = 3.00;
        public CMM cmm = new CMM();

        public void run()
        {
            cmm.setLEDNumber(12);

            cmm.setCoffeeType("Cappuccino");

            cmm.setGrindingTime(10);

            cmm.setTemperature(180);

            cmm.setLEDNumber(2);

            cmm.done();
        }

        public double getPrice()
        {
            return basePrice;
        }
    }
}
