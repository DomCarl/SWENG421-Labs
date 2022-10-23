using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class CMM
    {
        List<CoffeeIF> sales = new List<CoffeeIF>();
        double sale = 0;
        public string LED_Num = "";

        void setCoffeeType(string str)
        {
            
        }

        public void setGrindingTime(int sec)
        {
            Console.WriteLine("Grinding for {0} seconds", sec);
        }

        void addCondiment(CondimentIF type)
        {
            sale += type.getCharge();
        }

        public void setTemperature(int degree)
        {
            Console.WriteLine("Temperature set to {0} degrees", degree);
        }

        public void setLEDNumber(string num)
        {
            this.LED_Num = num; 
        }

        public double computePrice(CoffeeIF cif)
        {
            return cif.getBasePrice();
        }
        
        public void done()
        {
            this.LED_Num = "0";
        }
    }
}
