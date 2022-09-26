using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    internal interface COMPIF
    {
        void Set(double value);

        double Get();

        void Compute();
       
    }
}
