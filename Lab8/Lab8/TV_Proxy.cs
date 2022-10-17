/**
 * Jason Cross and Dominick Carlucci
 * TV_Proxy.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class TV_Proxy : TV, TV_IF
    {
        public object replenishTV(int budget)
        {
            if (budget >= getPrice())
            {
                return new Sony_UltraHD_TV().replenishTV(budget);
            }
            else
            {
                return new Visio_UltraHD_TV().replenishTV(budget);
            }
        }
    }
}
