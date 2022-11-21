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
            ListManager.createLinkLabelsLists();

            if (searchTB.Text == "")
            {
                MessageBox.Show("Please enter a search term.");
            }
            else
            {
                if (entreeRB.Checked)
                {
                    List<Recipe> results = new List<Recipe>();
                    results = ListManager.entreeList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> links = new List<LinkLabel>();
                    links = ListManager.entreeLinkLabels;

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
                else if (sideRB.Checked)
                {
                    List<Recipe> results = new List<Recipe>();
                    results = ListManager.sideList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> links = new List<LinkLabel>();
                    links = ListManager.sideLinkLabels;

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
                            FormManager.vs.entreelinks[i].Visible = true;
                            FormManager.vs.entreelinks[i].Text = results[i].name;
                        }
                    }
                }
                else if (dessertRB.Checked)
                {
                    List<Recipe> results = new List<Recipe>();
                    results = ListManager.dessertList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> links = new List<LinkLabel>();
                    links = ListManager.dessertLinkLabels;

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
                            FormManager.vs.entreelinks[i].Visible = true;
                            FormManager.vs.entreelinks[i].Text = results[i].name;
                        }
                    }
                }
                else if (snacksRB.Checked)
                {
                    List<Recipe> results = new List<Recipe>();
                    results = ListManager.snackList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> links = new List<LinkLabel>();
                    links = ListManager.snackLinkLabels;

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
                            FormManager.vs.entreelinks[i].Visible = true;
                            FormManager.vs.entreelinks[i].Text = results[i].name;
                        }
                    }
                }
                else if (allRB.Checked)
                {
                    List<Recipe> resultsEntree = new List<Recipe>();
                    resultsEntree = ListManager.entreeList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> entreelinks = new List<LinkLabel>();
                    entreelinks = ListManager.entreeLinkLabels;
                    List<Recipe> resultsSide = new List<Recipe>();
                    resultsSide = ListManager.sideList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> sidelinks = new List<LinkLabel>();
                    sidelinks = ListManager.sideLinkLabels;
                    List<Recipe> resultsDessert = new List<Recipe>();
                    resultsDessert = ListManager.dessertList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> dessertlinks = new List<LinkLabel>();
                    dessertlinks = ListManager.dessertLinkLabels;
                    List<Recipe> resultsSnack = new List<Recipe>();
                    resultsSnack = ListManager.snackList.FindAll(x => x.name.ToLower().Contains(searchTB.Text.ToLower()));
                    List<LinkLabel> snacklinks = new List<LinkLabel>();
                    snacklinks = ListManager.snackLinkLabels;

                    if (resultsEntree.Count == 0 && resultsSide.Count == 0 && resultsDessert.Count == 0 && resultsSnack.Count == 0)
                    {
                        MessageBox.Show("No results found all.");
                    }
                    else
                    {
                        Hide();
                        FormManager.vs.Show();
                        FormManager.vs.vsLbl.Text = "All Recipes";
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
                else
                {
                    MessageBox.Show("Please select a category to search.");
                }
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
                FormManager.vs.entreeLbl.Visible = true;
                FormManager.vs.linkLabel11.Visible = true;
                FormManager.vs.sideLbl.Visible = true;
                FormManager.vs.linkLabel21.Visible = true;
                FormManager.vs.dessertLbl.Visible = true;
                FormManager.vs.linkLabel31.Visible = true;
                FormManager.vs.snackLbl.Visible = true;
                FormManager.vs.linkLabel1.Text = ListManager.entreeList[randEntree].name;
                FormManager.vs.linkLabel11.Text = ListManager.sideList[randSide].name;
                FormManager.vs.linkLabel21.Text = ListManager.dessertList[randDessert].name;
                FormManager.vs.linkLabel31.Text = ListManager.snackList[randSnack].name;                
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }            
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ListManager.createLinkLabelsLists();
        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }
    }
}
