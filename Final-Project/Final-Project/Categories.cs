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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.mm.Show();
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

        public void entreeBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> results = new List<Recipe>();
            results = ListManager.entreeList.FindAll(x => x.category.ToLower().Contains("entree"));
            for (int i = 0; i < FormManager.vs.sidelinks.Count; i++)
            {
                FormManager.vs.sidelinks[i].Visible = false;
                FormManager.vs.dessertlinks[i].Visible = false;
                FormManager.vs.snacklinks[i].Visible = false;
            }

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Entrees";

                for (int i = 0; i < results.Count; i++)
                {
                    FormManager.vs.entreelinks[i].Visible = true;
                    FormManager.vs.entreelinks[i].Text = results[i].name;
                }
            }
        }

        public void sidesBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> results = new List<Recipe>();
            results = ListManager.sideList.FindAll(x => x.category.ToLower().Contains("side dish"));
            for (int i = 0; i < FormManager.vs.entreelinks.Count; i++)
            {
                FormManager.vs.entreelinks[i].Visible = false;
                FormManager.vs.dessertlinks[i].Visible = false;
                FormManager.vs.snacklinks[i].Visible = false;
            }

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Side Dishes";

                for (int i = 0; i < results.Count; i++)
                {
                    FormManager.vs.sidelinks[i].Visible = true;
                    FormManager.vs.sidelinks[i].Text = results[i].name;
                }
            }
        }

        public void dessertBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> results = new List<Recipe>();
            results = ListManager.dessertList.FindAll(x => x.category.ToLower().Contains("dessert"));
            for (int i = 0; i < FormManager.vs.entreelinks.Count; i++)
            {
                FormManager.vs.entreelinks[i].Visible = false;
                FormManager.vs.sidelinks[i].Visible = false;
                FormManager.vs.snacklinks[i].Visible = false;
            }

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Desserts";

                for (int i = 0; i < results.Count; i++)
                {
                    FormManager.vs.dessertlinks[i].Visible = true;
                    FormManager.vs.dessertlinks[i].Text = results[i].name;
                }
            }
        }

        public void snackBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> results = new List<Recipe>();
            results = ListManager.snackList.FindAll(x => x.category.ToLower().Contains("snack"));
            for (int i = 0; i < FormManager.vs.entreelinks.Count; i++)
            {
                FormManager.vs.entreelinks[i].Visible = false;
                FormManager.vs.sidelinks[i].Visible = false;
                FormManager.vs.dessertlinks[i].Visible = false;
            }

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Snacks";

                for (int i = 0; i < results.Count; i++)
                {
                    FormManager.vs.snacklinks[i].Visible = true;
                    FormManager.vs.snacklinks[i].Text = results[i].name;
                }
            }
        }

        private void searchMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.ss.Show();
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

        private void Categories_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void saveCBMI_Click(object sender, EventArgs e)
        {
            ListManager.SerializeLists();
            MessageBox.Show("Cookbook saved!");
        }

        private void aboutMI_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}
