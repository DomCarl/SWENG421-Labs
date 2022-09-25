using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Product : COMP
    {
        public override void Compute()
        {

        }

        public void Multiply(double val, MainForm mf)
        {
            double product = Get() * val;
            Set(product);

            mf.outputLabel.Text = product.ToString();
        }
    }
}
