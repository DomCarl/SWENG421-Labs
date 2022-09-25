using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Log: COMP
    {
        public override void Compute()
        {

        }

        public void LogEmDown(MainForm mf)
        {
            double log = Math.Log(Get());

            mf.outputLabel.Text = log.ToString();
        }
    }
}
