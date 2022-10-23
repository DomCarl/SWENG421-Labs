using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Espresso : USBProgram
    {
        readonly double basePrice = 5.00;
        public CMM cmm = new CMM();

        public override void run()
        {
            cmm.setLEDNumber(13);

            cmm.setCoffeeType("Espresso");

            cmm.setGrindingTime(5);

            cmm.setTemperature(200);

            cmm.setLEDNumber(3);

            cmm.done();
        }

        public double getPrice()
        {
            return basePrice;
        }
    }
}
