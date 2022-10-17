using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Sony_Smart_TV : Sony_TV, Smart_TV_IF
    {
        public Sony_Smart_TV()
        {
            setPrice(380);
            setType("Smart");
        }

        public Object replenishTV(int budget)
        {
            if (getPrice() <= budget)
            {
                getInfo();
                Console.WriteLine("Power usage is: " + getPowerUsage() + " watts per hour");
                return new Sony_Smart_TV();
            }
            else
            {
                return new Visio_Smart_TV().replenishTV(budget);
            }
        }

        internal double getPowerUsage()
        {
            return 5.15;
        }

        internal String getType()
        {
            return "Smart";
        }
    }
}
