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
        int sale = 0;

        void setCoffeeType(string str)
        {
            
        }

        void setGrindingTime(int sec)
        {
            Console.WriteLine("Grinding for {0} seconds", sec);
        }

        void addCondiment(CondimentIF type)
        {
            
        }

        void setTemperature(int degree)
        {
            Console.WriteLine("Temperature set to {0} degrees", degree);
        }

        void setLEDNumber(int num)
        {
            
        }

        public double computePrice(CoffeeIF cif)
        {
            return cif.getBasePrice();
        }
        
        void done()
        {
            
        }
    }
}
