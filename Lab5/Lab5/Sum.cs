/**
 * Sum.cs class
 * @author Jason Cross, Dominick Carlucci
 * Due Date: 9/25/22 11:59 p.m.
 */

using LanguageExt.ClassInstances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class Sum : COMP
    {
        //InputPopup ip = new InputPopup();
        //MainForm mf = new MainForm();

      
        public override void Compute()
        {
            Set(0);
            double value = Get();
            
            //ip.Show();
            //double val = mf.inputVal;

            MessageBox.Show("Computing sum");
            //AddEmUp(mf.Get());
        }

        public void AddEmUp(double val)
        {
            //MessageBox.Show("AddEmUp");
            //double sum = mf.Get() + val;

            //Set(sum);            
        }        
    }
}
