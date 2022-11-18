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
    public partial class ViewScreen : Form
    {
        public ViewScreen()
        {
            InitializeComponent();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.mm.Show();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormManager.ss.entreeRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.sideList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.snackList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "All Recipes";
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormManager.ss.entreeRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.sideList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.snackList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "All Recipes";
                var rec = ListManager.sideList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormManager.ss.entreeRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.sideList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.snackList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "All Recipes";
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FormManager.ss.entreeRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.sideList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.snackList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "All Recipes";
                var rec = ListManager.snackList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
