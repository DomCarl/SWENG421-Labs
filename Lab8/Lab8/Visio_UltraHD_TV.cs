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
            this.setPrice(450);
        }

        public Object replenishTV(int budget)
        {
            if (this.getPrice() <= budget)
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
