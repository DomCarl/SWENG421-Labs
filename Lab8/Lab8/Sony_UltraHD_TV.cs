/**
 * Jason Cross and Dominick Carlucci
 * Sony_UltraHD_TV.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Sony_UltraHD_TV : Sony_TV, UltraHD_TV_IF
    {
        public Sony_UltraHD_TV()
        {
            setPrice(480);
            setType("Ultra");
        }       

        public object replenishTV(int budget)
        {
            if (budget >= getPrice())
            {
                getInfo();
                return new Sony_UltraHD_TV();
            }
            else
            {
                return new Visio_UltraHD_TV().replenishTV(budget);
            }
        }

        internal string getType()
        {
            return "Ultra";
        }
    }
}
