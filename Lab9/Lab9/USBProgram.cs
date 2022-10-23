using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class USBProgram
    {
        string coffeeName = "";
        CMM cmm = new CMM();
        public USBProgram(string coffee_name)
        {
            this.coffeeName = coffee_name;
        }
        void run()
        {
            cmm.setLEDNumber("13");
            Console.WriteLine("LED Setting: " + cmm.LED_Num);

            cmm.setGrindingTime(5);

            cmm.setTemperature(200);

            cmm.setLEDNumber("03");
            Console.WriteLine("LED Setting: " + cmm.LED_Num);
        }
    }
}
