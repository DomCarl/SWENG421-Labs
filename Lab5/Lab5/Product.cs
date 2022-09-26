/**
 * Product.cs class
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
    public class Product : COMP
    {
        public override void Compute()
        {
            MessageBox.Show("Computing Product");
        }

        public void TimesIt(double val, MainForm mf)
        {
            double product = Get() * val;

            Set(product);

            mf.outputLabel.Text = product.ToString();
        }        
    }
}
