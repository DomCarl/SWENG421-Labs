using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Subtract : COMP
    {
        public override void Compute()
        {
           
        }

        public void TakeAway(double val, MainForm mf)
        {
            double diff = Get() - val;
            Set(diff);

            mf.outputLabel.Text = diff.ToString();
        }
    }
}
