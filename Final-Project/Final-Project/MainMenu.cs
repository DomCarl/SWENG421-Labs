using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Final_Project
{
    public partial class mainMenu : Form
    {
        public List<Recipe> entreeList = new List<Recipe>();
        public List<Recipe> sideList = new List<Recipe>();
        public List<Recipe> dessertList = new List<Recipe>();
        public List<Recipe> snackList = new List<Recipe>();

        public mainMenu()
        {
            InitializeComponent();            
        }

        private void newItemMI_Click(object sender, EventArgs e)
        {            
            Hide();
            FormManager.adds.Show();
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

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.ss.Show();
            //MessageBox.Show("HELLO");
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.cs.Show();
        }        

        private void dietsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.dp.Show();
        }             

        private void makeBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.mam.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.adds.Show();
        }

        private void makeMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.mam.Show();
        }

        private void dietMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.dp.Show();
        }

        private void entreesMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Entrees";
        }

        private void sidesMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Side Dishes";
        }

        private void dessertsMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Desserts";
        }

        private void snacksMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Snacks";
        }

        private void saveCBMI_Click(object sender, EventArgs e)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Recipe>));
            using (var s = System.IO.File.Create("Entrees.xml"))
            {
                xmlSerializer.Serialize(s, FormManager.mm.entreeList);
            }
            using (var s = System.IO.File.Create("Sides.xml"))
            {
                xmlSerializer.Serialize(s, FormManager.mm.sideList);
            }
            using (var s = System.IO.File.Create("Desserts.xml"))
            {
                xmlSerializer.Serialize(s, FormManager.mm.dessertList);
            }
            using (var s = System.IO.File.Create("Snacks.xml"))
            {
                xmlSerializer.Serialize(s, FormManager.mm.snackList);
            }
        }
    }
}
