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
        public List<LinkLabel> entreelinks = ListManager.entreeLinkLabels;
        public List<LinkLabel> sidelinks = ListManager.sideLinkLabels;
        public List<LinkLabel> dessertlinks = ListManager.dessertLinkLabels;
        public List<LinkLabel> snacklinks = ListManager.snackLinkLabels;

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
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }
            
            if (FormManager.ss.entreeRB.Checked)
            {
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                var rec = ListManager.sideList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                var rec = ListManager.snackList.Find(x => x.name == linkLabel1.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                if (ListManager.entreeList.Exists(x => x.name == linkLabel1.Text))
                {
                    var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.sideList.Exists(x => x.name == linkLabel1.Text))
                {
                    var rec = ListManager.sideList.Find(x => x.name == linkLabel1.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.dessertList.Exists(x => x.name == linkLabel1.Text))
                {
                    var rec = ListManager.dessertList.Find(x => x.name == linkLabel1.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.snackList.Exists(x => x.name == linkLabel1.Text))
                {
                    var rec = ListManager.snackList.Find(x => x.name == linkLabel1.Text);
                    FormManager.adds.displayRecipe(rec);
                }                
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
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel2.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                var rec = ListManager.sideList.Find(x => x.name == linkLabel2.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel2.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                var rec = ListManager.snackList.Find(x => x.name == linkLabel2.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                if (ListManager.entreeList.Exists(x => x.name == linkLabel2.Text))
                {
                    var rec = ListManager.entreeList.Find(x => x.name == linkLabel2.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.sideList.Exists(x => x.name == linkLabel2.Text))
                {
                    var rec = ListManager.sideList.Find(x => x.name == linkLabel2.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.dessertList.Exists(x => x.name == linkLabel2.Text))
                {
                    var rec = ListManager.dessertList.Find(x => x.name == linkLabel2.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.snackList.Exists(x => x.name == linkLabel2.Text))
                {
                    var rec = ListManager.snackList.Find(x => x.name == linkLabel2.Text);
                    FormManager.adds.displayRecipe(rec);
                }
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
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel3.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                var rec = ListManager.sideList.Find(x => x.name == linkLabel3.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel3.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                var rec = ListManager.snackList.Find(x => x.name == linkLabel3.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                if (ListManager.entreeList.Exists(x => x.name == linkLabel3.Text))
                {
                    var rec = ListManager.entreeList.Find(x => x.name == linkLabel3.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.sideList.Exists(x => x.name == linkLabel3.Text))
                {
                    var rec = ListManager.sideList.Find(x => x.name == linkLabel3.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.dessertList.Exists(x => x.name == linkLabel3.Text))
                {
                    var rec = ListManager.dessertList.Find(x => x.name == linkLabel3.Text);
                    FormManager.adds.displayRecipe(rec);
                }
                else if (ListManager.snackList.Exists(x => x.name == linkLabel3.Text))
                {
                    var rec = ListManager.snackList.Find(x => x.name == linkLabel3.Text);
                    FormManager.adds.displayRecipe(rec);
                }
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
                var rec = ListManager.entreeList.Find(x => x.name == linkLabel4.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.sideRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.sideList.Find(x => x.name == linkLabel4.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.dessertRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.dessertList.Find(x => x.name == linkLabel4.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.snacksRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                var rec = ListManager.snackList.Find(x => x.name == linkLabel4.Text);
                FormManager.adds.displayRecipe(rec);
            }
            else if (FormManager.ss.allRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "All Recipes";
                var rec = ListManager.snackList.Find(x => x.name == linkLabel4.Text);
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
