using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class UltraHD_TV : TV
    {
        private int price = 400;

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
            return "UltraHD TV";
        }

        public UltraHD_TV replenishUltraHD_TV(int budget)
        {
            if (budget >= price)
            {
                return new UltraHD_TV();
            }
            else
            {
                return null;
            }
        }
    }    
}
