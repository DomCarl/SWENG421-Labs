/**
 * Jason Cross and Dominick Carlucci
 * TV.cs class
 * Due Date: 10/16/22
 */

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
        private string type = "Regular";

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

        internal void setType(string type)
        {
            this.type = type;
        }

        internal string getType()
        {
            return type;
        }

        public object replenishTV(int budget)
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
