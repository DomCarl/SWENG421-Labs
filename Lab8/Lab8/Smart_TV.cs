/**
 * Jason Cross and Dominick Carlucci
 * Smart_TV.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public sealed class Smart_TV : TV
    {
        public Smart_TV_IF stvif;
        
        public Smart_TV()
        {
            setPrice(300);
            setType("Smart");
        }

        public object replenishTV(int budget)
        {
            if (getPrice() <= budget)
            {
                getInfo();                
                Console.WriteLine("Power usage is: " + getPowerUsage() + " watts per hour");
                return new Smart_TV();
            }
            else
            {
                return new Sony_TV().replenishTV(budget);
            }
        }

        internal double getPowerUsage()
        {
            return 5.5;
        }        
    }
}
