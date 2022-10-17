using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Visio_TV : TV_IF
    {
        private int price = 250;
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
            Console.WriteLine("The brand is " + getBrand() + ", the price is $" + getPrice() + ", and the type is " + getType());
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
                return new Visio_TV();
            }
            else
            {
                return new TV().replenishTV(budget);
            }
        }

        internal String getBrand()
        {
            return "Visio";
        }
    }
}
