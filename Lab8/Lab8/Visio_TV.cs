using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Visio_TV
    {
        private int price = 250;

        void setPrice(int price)
        {
            this.price = price;
        }

        int getPrice()
        {
            return this.price;
        }

        public void getInfo()
        {
            Console.WriteLine("The price is " + this.getPrice() + " and the type is " + this.getType());
        }

        String getType()
        {
            return "TV";
        }

        public TV replenishTV(int budget)
        {
            if (budget >= 450)
            {
                return new TV();
            }
            else
            {
                return null;
            }
        }

        String getBrand()
        {
            return "Visio";
        }
    }
}
