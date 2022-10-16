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
            Console.WriteLine("Type: " + this.getType() + " Price: " + this.getPrice());
        }

        internal String getType()
        {
            return this.ToString();
        }

        public TV replenishTV(int budget)
        {
            if (this.price <= budget)
            {
                return new TV();
            }
            else
            {
                return null;
            }
        }
    }
}
