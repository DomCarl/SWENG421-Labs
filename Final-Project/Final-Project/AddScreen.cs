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
    public partial class AddScreen : Form
    {
        public AddScreen()
        {
            InitializeComponent();
        }

        private void closeMI_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }

        private void addPicBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;

            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                pb1.Image = Image.FromFile(fileName);
            }
        }
    }
}
