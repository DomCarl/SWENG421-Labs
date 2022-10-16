using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    internal class TV
    {
        private int price = 200;

        void setPrice(int price)
        {
            this.price = price;
        }

        int getPrice()
        {
            return price;
        }

        public void getInfo()
        {
            this.getPrice();
            this.getType();
        }

        String getType()
        {
            return "TV";
        }

        public TV replenishTV(int budget)
        {
            if (budget >= price)
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
