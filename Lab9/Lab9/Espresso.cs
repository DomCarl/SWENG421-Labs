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

        public void run()
        {
            cmm.setLEDNumber(13);

            cmm.setGrindingTime(5);

            cmm.setTemperature(200);

            cmm.setLEDNumber(3);
        }

        public new double getPrice()
        {
            return basePrice;
        }
    }
}
