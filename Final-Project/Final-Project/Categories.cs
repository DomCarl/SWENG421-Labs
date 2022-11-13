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
            System.Windows.Forms.Application.Exit();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.mm.Show();
        }

        private void closeMI_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void newItemMI_Click(object sender, EventArgs e)
        {

        }

        private void entreeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Barking up the wrong Entrees";
        }

        private void sidesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Side Dishes, bishes!";
        }

        private void dessertBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "No sand in these Desserts!";
        }

        private void snackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Snack attack!";
        }
    }
}
