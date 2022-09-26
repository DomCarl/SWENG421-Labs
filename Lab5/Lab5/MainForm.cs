/**
 * MainForm.cs class
 * @author Jason Cross, Dominick Carlucci
 * Due Date: 9/25/22 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LanguageExt.ClassInstances;
using System.Reflection;

namespace Lab5
{
    public partial class MainForm : Form
    {
        public InputPopup ip;
        //public double inputVal;
        public string module;        

        public MainForm()
        {
            InitializeComponent();

            string inFile = @"C:\Users\Jason\OneDrive\Desktop\School\Fall 2022\SWENG 421\Labs\SWENG421-Labs\Lab5\Lab5\modules.txt";

            if (File.Exists(inFile))
            {
                string[] modules = File.ReadAllLines(inFile);

                Array.Sort(modules);

                foreach (string mod in modules)
                {
                    this.compCB.Items.Add(mod);                    
                }                

                ip = new InputPopup();
            }
            else
            {
                MessageBox.Show("File does not exist");
            }            
        }

        /*public void Set(double value)
        {
            inputVal = value;
        }*/

        public string Get()
        {
            return module;
        }

        private void compCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            module = compCB.SelectedItem.ToString();

            Type t = Type.GetType("Lab5." + module);
            Object o = Activator.CreateInstance(t);
            MethodInfo mi = t.GetMethod("Compute");
            ip.Show();
            mi.Invoke(o, null);

            this.outputLabel.Text = ip.inputVal.ToString();

        }
    }
}
