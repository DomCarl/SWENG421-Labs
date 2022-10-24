/**
* Jason Cross and Dominick Carlucci
* USBProgram.cs class
* Due Date: 10/23/2022 11:59 p.m.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal abstract class USBProgram : CoffeeIF
    {
        CoffeeIF cif;
        CondimentIF cdif;

        public abstract void run();
        

        public double getPrice()
        { 
            return cif.getPrice() + cdif.getCharge();
        }
    }
}
