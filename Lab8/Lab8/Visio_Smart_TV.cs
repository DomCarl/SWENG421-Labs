using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Visio_Smart_TV : Visio_TV
    {
        private double wattUsage = 6.35;
        private int price = 350;

        String getType()
        {
            return "Smart TV";
        }

        double getPowerUsage()
        {
            return wattUsage;
        }

        int getPrice()
        {
            return price;
        }

        public void getInfo()
        {
            Console.WriteLine("The price is " + this.getPrice() + " and the type is " + this.getType());
        }
    }
}
