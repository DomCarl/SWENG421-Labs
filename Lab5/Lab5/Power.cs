using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Power : COMP
    {
        public override void Compute()
        {

        }

        public void PowPow(double val, MainForm mf)
        {
            double result = Math.Pow(Get(), val);

            Set(result);

            mf.outputLabel.Text = result.ToString();
        }
    }
}
