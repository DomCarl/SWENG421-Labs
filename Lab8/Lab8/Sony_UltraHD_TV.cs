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
            this.setPrice(480);
        }       

        public Object replenishTV(int budget)
        {
            if (this.getPrice() <= budget)
            {
                getInfo();
                return new Sony_UltraHD_TV();
            }
            else
            {
                return new Visio_UltraHD_TV().replenishTV(budget);
            }
        }
    }
}
