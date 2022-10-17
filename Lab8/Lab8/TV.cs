using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class TV
    {
        private int price = 200;
        private String type = "Regular";

        internal void setPrice(int price)
        {
            this.price = price;
        }

        internal int getPrice()
        {
            return price;
        }

        public void getInfo()
        {
            Console.WriteLine("The price is $" + getPrice() + ", and the type is " + getType());
        }

        internal void setType(String type)
        {
            this.type = type;
        }

        internal String getType()
        {
            return type;
        }

        public Object replenishTV(int budget)
        {
            if (budget >= price)
            {
                getInfo();
                return new TV();
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy a TV, bro!");
                return null;
            }
        }
    }
}
