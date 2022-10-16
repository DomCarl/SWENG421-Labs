using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    internal class Smart_TV : TV
    {
        private int price = 300;

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
            return "Smart TV";
        }

        public Smart_TV replenishSmartTV(int budget)
        {
            if (budget >= price)
            {
                return new Smart_TV();
            }
            else
            {
                return null;
            }
        }
    }
}
