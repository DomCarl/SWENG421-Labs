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
    }
}
