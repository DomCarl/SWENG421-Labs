/**
 * Jason Cross and Dominick Carlucci
 * Vanilla.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

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
