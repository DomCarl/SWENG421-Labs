using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class COMP
    {
        private double currentValue;

        public COMP()
        {
            
        }

        public void Set(double value)
        {
            currentValue = value;
        }

        public double Get()
        {
            return currentValue;
        }

        public virtual void Compute()
        {
            
        }
    }
}
