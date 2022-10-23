/**
 * Jason Cross and Dominick Carlucci
 * Cream.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Cream : CondimentIF
    {
        double charge = .25;

        public double getCharge()
        {
            return charge;
        }
    }    
}
