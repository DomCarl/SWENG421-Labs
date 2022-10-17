/**
 * Jason Cross and Dominick Carlucci
 * TV_IF.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public interface TV_IF
    {
        public object replenishTV(int budget);
        public void getInfo();
    }
}
