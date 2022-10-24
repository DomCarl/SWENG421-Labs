/**
 * Jason Cross and Dominick Carlucci
 * Mocha.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

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
        CMM cmm;

        public Mocha(CMM cmm)
        {
            this.cmm = cmm;
        }

        public void run()
        {
            cmm.setLEDNumber(11);

            cmm.setCoffeeType("Mocha");

            cmm.setGrindingTime(8);

            cmm.setTemperature(150);

            cmm.setLEDNumber(1);

            cmm.sales.Add(this);

            cmm.done("Mocha");
        }

        public double getPrice()
        {
            return basePrice;
        }
    }
}
