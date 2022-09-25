using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class InputPopup : Form
    {
        public double inputVal;
        
        public InputPopup()
        {
            InitializeComponent();
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            inputVal = Convert.ToDouble(inputTB.Text);            
        }
    }
}
