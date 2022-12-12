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
            List<Recipe> entreeResults = new List<Recipe>();
            entreeResults = ListManager.entreeList.FindAll(x => x.name.ToLower().Contains(servTB.Text.ToLower()));
            List<Recipe> sideResults = new List<Recipe>();
            sideResults = ListManager.sideList.FindAll(x => x.name.ToLower().Contains(servTB.Text.ToLower()));
            List<Recipe> dessertResults = new List<Recipe>();
            dessertResults = ListManager.dessertList.FindAll(x => x.name.ToLower().Contains(servTB.Text.ToLower()));
            List<Recipe> snackResults = new List<Recipe>();
            snackResults = ListManager.snackList.FindAll(x => x.name.ToLower().Contains(servTB.Text.ToLower()));

            if (recTB.Text == "" || servTB.Text == "")
            {
                MessageBox.Show("Please enter a search term and number of servings.");
            }
            else if (entreeResults.Count)
        }
    }
}
