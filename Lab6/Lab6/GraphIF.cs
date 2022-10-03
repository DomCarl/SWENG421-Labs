/**
 * Jason Cross and Dominick Carlucci
 * GraphIF.cs class
 * Due Date: 10/2/22 11:59 pm
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public interface GraphIF : ICloneable
    {
        void print(int graphID);

        int getID();

        void setID(int id);
        
    }    
}
