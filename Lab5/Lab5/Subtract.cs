/**
 * Subtract.cs class
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
    public class Subtract : COMP
    {
        public override void Compute()
        {
            MessageBox.Show("Computing difference");
        }

        public void MinusIt(double val, MainForm mf)
        {
            double diff = Get() - val;

            Set(diff);

            mf.outputLabel.Text = diff.ToString();
        }
    }
}
