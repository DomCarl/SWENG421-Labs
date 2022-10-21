using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Vanilla : CondimentIF
    {
        double charge = .50;

        public double getCharge()
        {
            return charge;
        }
    }    
}
