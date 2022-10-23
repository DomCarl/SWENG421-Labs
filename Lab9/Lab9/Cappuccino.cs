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

        void run()
        {
            cmm.setLEDNumber("11");
            Console.WriteLine("LED Setting: " + cmm.LED_Num);

            cmm.setGrindingTime(8);

            cmm.setTemperature(150);

            cmm.setLEDNumber("01");
            Console.WriteLine("LED Setting: " + cmm.LED_Num);
        }

        public double getBasePrice()
        {
            return basePrice;
        }
    }
}
