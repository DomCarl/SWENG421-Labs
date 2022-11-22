using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class RecipeCalc : Form
    {
        public RecipeCalc()
        {
            InitializeComponent();
        }

        private void RecipeCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
