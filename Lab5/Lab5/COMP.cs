/**
 * COMP.cs class
 * @author Jason Cross, Dominick Carlucci
 * Due Date: 9/25/22 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public abstract class COMP: COMPIF
    {
        private double currentValue = 15;        

        public void Set(double value)
        {
            currentValue = value;
            //MessageBox.Show("SETTING STUFF");
        }

        public double Get()
        {
            //MessageBox.Show("GETTING STUFF");
            return currentValue;
        }

        public virtual void Compute()
        {
           
        }
    }
}
