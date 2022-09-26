/**
 * Power.cs class
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
    public class Power : COMP
    {
        public override void Compute()
        {
            MessageBox.Show("Computing exponential");
        }

        public void PowPow(double val, MainForm mf)
        {
            double pow = Math.Pow(Get(), val);

            Set(pow);

            mf.outputLabel.Text = pow.ToString();
        }
    }
}
