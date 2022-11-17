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
            this.Hide();
            FormManager.mm.Show();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void closeMI_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void newItemMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.adds.Show();
        }

        private void makeAMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.mam.Show();
        }

        private void dietPlansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.dp.Show();
        }

        private void entreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Entrees";
        }

        private void sideDishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Side Dishes";
        }

        private void dessertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Desserts";
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Snacks";
        }

        private void SearchScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var searchRecipe = FormManager.mm.recipes.FirstOrDefault(x => x.name == searchTB.Text);
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = searchRecipe.name;
            FormManager.vs.typeLbl.Text = searchRecipe.category;
            FormManager.vs.dietLbl.Text = searchRecipe.diet;
            FormManager.vs.servingsLbl.Text = searchRecipe.servings.ToString();            
        }

        private void surpriseBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, FormManager.mm.recipes.Count);
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = FormManager.mm.recipes[r].name;
            FormManager.vs.typeLbl.Text = FormManager.mm.recipes[r].category;
            FormManager.vs.dietLbl.Text = FormManager.mm.recipes[r].diet;
            FormManager.vs.servingsLbl.Text = FormManager.mm.recipes[r].servings.ToString();
        }
    }
}
