using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Visio_UltraHD_TV : Visio_TV
    {
        private int price = 450;

        String getType()
        {
            return "UltraHD TV";
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
