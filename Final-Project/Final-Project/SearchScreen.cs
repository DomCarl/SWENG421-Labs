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
    public partial class SearchScreen : Form
    {
        Recipe r;
        
        public SearchScreen()
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

        private void closeMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newItemMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.adds.Show();
        }

        private void makeAMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.mam.Show();
        }

        private void dietPlansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.dp.Show();
        }

        private void entreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Entrees";
        }

        private void sideDishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Side Dishes";
        }

        private void dessertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Desserts";
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Snacks";
        }

        private void SearchScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (entreeRB.Checked)
            {
                List<Recipe> results = ListManager.entreeList.FindAll(x => x.name.Contains(searchTB.Text));

                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Entrees";
            }
            else if (sideRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Side Dishes";
            }
            else if (dessertRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Desserts";
            }
            else if (snacksRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Snacks";
            }
            else if (allRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "All Recipes";
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }                        
        }

        private void surpriseBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randEntree = rnd.Next(0, ListManager.entreeList.Count);
            int randSide = rnd.Next(0, ListManager.sideList.Count);
            int randDessert = rnd.Next(0, ListManager.dessertList.Count);
            int randSnack = rnd.Next(0, ListManager.snackList.Count);
            
            if (entreeRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Entrees";
                FormManager.vs.linkLabel1.Visible = true;
                FormManager.vs.linkLabel1.Text = ListManager.entreeList[randEntree].name;                
            }
            else if (sideRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Side Dishes";
                FormManager.vs.linkLabel1.Visible = true;
                FormManager.vs.linkLabel1.Text = ListManager.sideList[randSide].name;                
            }
            else if (dessertRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Desserts";
                FormManager.vs.linkLabel1.Visible = true;
                FormManager.vs.linkLabel1.Text = ListManager.dessertList[randDessert].name;                
            }
            else if (snacksRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Snacks";
                FormManager.vs.linkLabel1.Visible = true;
                FormManager.vs.linkLabel1.Text = ListManager.snackList[randSnack].name;                
            }
            else if (allRB.Checked)
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "All Recipes";
                FormManager.vs.linkLabel1.Visible = true;
                FormManager.vs.linkLabel2.Visible = true;
                FormManager.vs.linkLabel3.Visible = true;
                FormManager.vs.linkLabel4.Visible = true;
                FormManager.vs.linkLabel1.Text = ListManager.entreeList[randEntree].name;
                FormManager.vs.linkLabel2.Text = ListManager.sideList[randSide].name;
                FormManager.vs.linkLabel3.Text = ListManager.dessertList[randDessert].name;
                FormManager.vs.linkLabel4.Text = ListManager.snackList[randSnack].name;                
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }            
        }
    }
}
