/**
 * Jason Cross and Dominick Carlucci
 * UltraHD_TV.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public sealed class UltraHD_TV : TV
    {
        public UltraHD_TV()
        {
            setPrice(400);
            setType("Ultra");
        }

        public object replenishTV(int budget)
        {
            if (this.getPrice() <= budget)
            {
                getInfo();                
                return new UltraHD_TV();
            }
            else
            {
                return new Sony_Smart_TV().replenishTV(budget);
            }
        }
    }
}
