/**
 * Initialize.cs class
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
    public class Initialize : COMP
    {
        public override void Compute()
        {
            Set(0);
            MessageBox.Show("Initializing");
        }
    }
}
