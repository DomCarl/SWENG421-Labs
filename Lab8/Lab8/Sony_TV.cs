/**
 * Jason Cross and Dominick Carlucci
 * Sony_TV.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Sony_TV : TV_IF
    {
        private int price = 280;
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
            Console.WriteLine("The brand is " + getBrand() + ", the price is $" + getPrice() + ", and the type is " + getType());
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
                return new Sony_TV();
            }
            else
            {
                return new Visio_TV().replenishTV(budget);
            }
        }

        internal string getBrand()
        {
            return "Sony";
        }
    }
}
