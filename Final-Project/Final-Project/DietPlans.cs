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
    public partial class DietPlans : Form
    {
        public DietPlans()
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

        private void DietPlans_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newItemMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.adds.Show();
        }

        private void saveCBMI_Click(object sender, EventArgs e)
        {
            ListManager.SerializeLists();
            MessageBox.Show("Cookbook saved!");
        }

        private void closeMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void entreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.cs.entreeBtn_Click(sender, e);
        }

        private void sideDishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.cs.sidesBtn_Click(sender, e);
        }

        private void dessertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.cs.dessertBtn_Click(sender, e);
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.cs.snackBtn_Click(sender, e);
        }

        private void aboutMI_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
        
        private void standardBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.diet.ToLower().Contains("standard"));
            List<Recipe> resultsSide = ListManager.sideList.FindAll(x => x.diet.ToLower().Contains("standard"));
            List<Recipe> resultsDessert = ListManager.dessertList.FindAll(x => x.diet.ToLower().Contains("standard"));
            List<Recipe> resultsSnack = ListManager.snackList.FindAll(x => x.diet.ToLower().Contains("standard"));

            for (int i = 0; i < FormManager.vs.sidelinks.Count; i++)
            {
                FormManager.vs.entreelinks[i].Visible = false;
                FormManager.vs.sidelinks[i].Visible = false;
                FormManager.vs.dessertlinks[i].Visible = false;
                FormManager.vs.snacklinks[i].Visible = false;
            }

            if (resultsEntree.Count == 0 && resultsSide.Count == 0 && resultsDessert.Count == 0 && resultsSnack.Count == 0)           
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Standard Diet Options";

                FormManager.vs.entreeLbl.Visible = true;
                FormManager.vs.sideLbl.Visible = true;
                FormManager.vs.dessertLbl.Visible = true;
                FormManager.vs.snackLbl.Visible = true;

                for (int i = 0; i < resultsEntree.Count; i++)
                {
                    FormManager.vs.entreelinks[i].Visible = true;
                    FormManager.vs.entreelinks[i].Text = resultsEntree[i].name;
                }
                for (int i = 0; i < resultsSide.Count; i++)
                {
                    FormManager.vs.sidelinks[i].Visible = true;
                    FormManager.vs.sidelinks[i].Text = resultsSide[i].name;
                }
                for (int i = 0; i < resultsDessert.Count; i++)
                {
                    FormManager.vs.dessertlinks[i].Visible = true;
                    FormManager.vs.dessertlinks[i].Text = resultsDessert[i].name;
                }
                for (int i = 0; i < resultsSnack.Count; i++)
                {
                    FormManager.vs.snacklinks[i].Visible = true;
                    FormManager.vs.snacklinks[i].Text = resultsSnack[i].name;
                }
            }
        }

        private void ketoBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.diet.ToLower().Contains("keto"));
            List<Recipe> resultsSide = ListManager.sideList.FindAll(x => x.diet.ToLower().Contains("keto"));
            List<Recipe> resultsDessert = ListManager.dessertList.FindAll(x => x.diet.ToLower().Contains("keto"));
            List<Recipe> resultsSnack = ListManager.snackList.FindAll(x => x.diet.ToLower().Contains("keto"));

            for (int i = 0; i < FormManager.vs.sidelinks.Count; i++)
            {
                FormManager.vs.entreelinks[i].Visible = false;
                FormManager.vs.sidelinks[i].Visible = false;
                FormManager.vs.dessertlinks[i].Visible = false;
                FormManager.vs.snacklinks[i].Visible = false;
            }

            if (resultsEntree.Count == 0 && resultsSide.Count == 0 && resultsDessert.Count == 0 && resultsSnack.Count == 0)
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "Keto Diet Options";

                FormManager.vs.entreeLbl.Visible = true;
                FormManager.vs.sideLbl.Visible = true;
                FormManager.vs.dessertLbl.Visible = true;
                FormManager.vs.snackLbl.Visible = true;

                for (int i = 0; i < resultsEntree.Count; i++)
                {
                    FormManager.vs.entreelinks[i].Visible = true;
                    FormManager.vs.entreelinks[i].Text = resultsEntree[i].name;
                }
                for (int i = 0; i < resultsSide.Count; i++)
                {
                    FormManager.vs.sidelinks[i].Visible = true;
                    FormManager.vs.sidelinks[i].Text = resultsSide[i].name;
                }
                for (int i = 0; i < resultsDessert.Count; i++)
                {
                    FormManager.vs.dessertlinks[i].Visible = true;
                    FormManager.vs.dessertlinks[i].Text = resultsDessert[i].name;
                }
                for (int i = 0; i < resultsSnack.Count; i++)
                {
                    FormManager.vs.snacklinks[i].Visible = true;
                    FormManager.vs.snacklinks[i].Text = resultsSnack[i].name;
                }
            }
        }

        private void sbBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.diet.ToLower().Contains("south beach"));
            List<Recipe> resultsSide = ListManager.sideList.FindAll(x => x.diet.ToLower().Contains("south beach"));
            List<Recipe> resultsDessert = ListManager.dessertList.FindAll(x => x.diet.ToLower().Contains("south beach"));
            List<Recipe> resultsSnack = ListManager.snackList.FindAll(x => x.diet.ToLower().Contains("south beach"));

            for (int i = 0; i < FormManager.vs.sidelinks.Count; i++)
            {
                FormManager.vs.entreelinks[i].Visible = false;
                FormManager.vs.sidelinks[i].Visible = false;
                FormManager.vs.dessertlinks[i].Visible = false;
                FormManager.vs.snacklinks[i].Visible = false;
            }

            if (resultsEntree.Count == 0 && resultsSide.Count == 0 && resultsDessert.Count == 0 && resultsSnack.Count == 0)
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "South Beach Diet Options";

                FormManager.vs.entreeLbl.Visible = true;
                FormManager.vs.sideLbl.Visible = true;
                FormManager.vs.dessertLbl.Visible = true;
                FormManager.vs.snackLbl.Visible = true;

                for (int i = 0; i < resultsEntree.Count; i++)
                {
                    FormManager.vs.entreelinks[i].Visible = true;
                    FormManager.vs.entreelinks[i].Text = resultsEntree[i].name;
                }
                for (int i = 0; i < resultsSide.Count; i++)
                {
                    FormManager.vs.sidelinks[i].Visible = true;
                    FormManager.vs.sidelinks[i].Text = resultsSide[i].name;
                }
                for (int i = 0; i < resultsDessert.Count; i++)
                {
                    FormManager.vs.dessertlinks[i].Visible = true;
                    FormManager.vs.dessertlinks[i].Text = resultsDessert[i].name;
                }
                for (int i = 0; i < resultsSnack.Count; i++)
                {
                    FormManager.vs.snacklinks[i].Visible = true;
                    FormManager.vs.snacklinks[i].Text = resultsSnack[i].name;
                }
            }
        }

        private void sfBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.diet.ToLower().Contains("see food"));
            List<Recipe> resultsSide = ListManager.sideList.FindAll(x => x.diet.ToLower().Contains("see food"));
            List<Recipe> resultsDessert = ListManager.dessertList.FindAll(x => x.diet.ToLower().Contains("see food"));
            List<Recipe> resultsSnack = ListManager.snackList.FindAll(x => x.diet.ToLower().Contains("see food"));

            for (int i = 0; i < FormManager.vs.sidelinks.Count; i++)
            {
                FormManager.vs.entreelinks[i].Visible = false;
                FormManager.vs.sidelinks[i].Visible = false;
                FormManager.vs.dessertlinks[i].Visible = false;
                FormManager.vs.snacklinks[i].Visible = false;
            }

            if (resultsEntree.Count == 0 && resultsSide.Count == 0 && resultsDessert.Count == 0 && resultsSnack.Count == 0)
            {
                MessageBox.Show("No results found.");
            }
            else
            {
                Hide();
                FormManager.vs.Show();
                FormManager.vs.vsLbl.Text = "See Food Diet Options";

                FormManager.vs.entreeLbl.Visible = true;
                FormManager.vs.sideLbl.Visible = true;
                FormManager.vs.dessertLbl.Visible = true;
                FormManager.vs.snackLbl.Visible = true;

                for (int i = 0; i < resultsEntree.Count; i++)
                {
                    FormManager.vs.entreelinks[i].Visible = true;
                    FormManager.vs.entreelinks[i].Text = resultsEntree[i].name;
                }
                for (int i = 0; i < resultsSide.Count; i++)
                {
                    FormManager.vs.sidelinks[i].Visible = true;
                    FormManager.vs.sidelinks[i].Text = resultsSide[i].name;
                }
                for (int i = 0; i < resultsDessert.Count; i++)
                {
                    FormManager.vs.dessertlinks[i].Visible = true;
                    FormManager.vs.dessertlinks[i].Text = resultsDessert[i].name;
                }
                for (int i = 0; i < resultsSnack.Count; i++)
                {
                    FormManager.vs.snacklinks[i].Visible = true;
                    FormManager.vs.snacklinks[i].Text = resultsSnack[i].name;
                }
            }
        }
    }
}
