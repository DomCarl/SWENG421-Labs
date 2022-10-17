/**
 * Jason Cross and Dominick Carlucci
 * Visio_UltraHD_TV.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Visio_UltraHD_TV : Visio_TV, UltraHD_TV_IF
    {
        public Visio_UltraHD_TV()
        {
            setPrice(450);
            setType("Ultra");
        }

        public object replenishTV(int budget)
        {
            if (getPrice() <= budget)
            {
                getInfo();                
                return new Visio_UltraHD_TV();
            }
            else
            {
                return new UltraHD_TV().replenishTV(budget);
            }
        }        
    }
}
