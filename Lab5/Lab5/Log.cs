/**
 * Log.cs class
 * @author Jason Cross, Dominick Carlucci
 * Due Date: 9/25/22 11:59 p.m.
 */

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
            LogEmDown();
        }

        public void LogEmDown()
        {
            double log = Math.Log(Get());

            Set(log);            
        }
    }
}
