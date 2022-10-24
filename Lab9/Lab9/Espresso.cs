/**
* Jason Cross and Dominick Carlucci
* Espresso.cs class
* Due Date: 10/23/2022 11:59 p.m.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Espresso : CoffeeIF
    {
        readonly double basePrice = 5.00;
        public CMM cmm;

        public Espresso(CMM cmm)
        {
            this.cmm = cmm;
        }

        public void run()
        {
            cmm.setLEDNumber(13);

            cmm.setGrindingTime(5);

            cmm.setTemperature(200);

            cmm.setLEDNumber(3);

            cmm.sales.Add(this);

            cmm.done("Espresso");
        }

        public double getPrice()
        {
            return basePrice;
        }
    }
}
