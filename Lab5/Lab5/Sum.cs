using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Sum : COMP
    {
        public override void Compute()
        {
            
        }

        public void AddEmUp(double val)
        {
            double sum = Get() + val;

            Set(sum);

            MainForm.outputLabel.Text = sum.ToString();
        }
    }
}
