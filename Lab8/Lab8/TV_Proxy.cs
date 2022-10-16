using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class TV_Proxy : TV, TV_IF
    {

        public TV base_tv;
        public TV_IF sony_tvif = new Sony_TV();
        public TV_IF visio_tvif = new Visio_TV();
        

        public Object replenishTV(int budget)
        {
            if (this.getPrice() <= budget)
            {
                return new Sony_UltraHD_TV();
            }
            else
            {
                return new Visio_UltraHD_TV().replenishTV(budget);
            }
        }        
    }
}
