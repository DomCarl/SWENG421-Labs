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

        public Object replenishTV(int budget)
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

        internal String getType()
        {
            return "Ultra";
        }
    }
}
