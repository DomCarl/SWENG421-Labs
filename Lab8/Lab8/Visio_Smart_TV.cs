using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Visio_Smart_TV : Visio_TV, Smart_TV_IF
    {
        public Visio_Smart_TV()
        {
            this.setPrice(350);
        }

        public Object replenishTV(int budget)
        {
            if (this.getPrice() <= budget)
            {
                getInfo();
                Console.WriteLine("Power usage is: " + getPowerUsage() + " watts per hour");
                return new Visio_Smart_TV();
            }
            else
            {
                return new Smart_TV().replenishTV(budget);
            }
        }

        internal double getPowerUsage()
        {
            return 6.35;
        }
    }
}
