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
        string fileName;
        
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
            Recipe r = new Recipe();
            r.setValues(nameTB.Text, typeCB.SelectedItem.ToString(), dietCB.SelectedItem.ToString(), Convert.ToDouble(servingsTB.Text), new Dictionary<string, double>(), new List<string>(), fileName, dirTB.Text);

            r.addIngredients(ingTB1.Text, Convert.ToDouble(amtTB1.Text), unitTB1.Text);
            r.addIngredients(ingTB2.Text, Convert.ToDouble(amtTB2.Text), unitTB2.Text);
            r.addIngredients(ingTB3.Text, Convert.ToDouble(amtTB3.Text), unitTB3.Text);
            r.addIngredients(ingTB4.Text, Convert.ToDouble(amtTB4.Text), unitTB4.Text);
            r.addIngredients(ingTB5.Text, Convert.ToDouble(amtTB5.Text), unitTB5.Text);
            r.addIngredients(ingTB6.Text, Convert.ToDouble(amtTB6.Text), unitTB6.Text);
            r.addIngredients(ingTB7.Text, Convert.ToDouble(amtTB7.Text), unitTB7.Text);
            r.addIngredients(ingTB8.Text, Convert.ToDouble(amtTB8.Text), unitTB8.Text);
            r.addIngredients(ingTB9.Text, Convert.ToDouble(amtTB9.Text), unitTB9.Text);
            r.addIngredients(ingTB10.Text, Convert.ToDouble(amtTB10.Text), unitTB10.Text);
            r.addIngredients(ingTB11.Text, Convert.ToDouble(amtTB11.Text), unitTB11.Text);
            
            r.recipeCount++;
            FormManager.mm.recipes.Add(r);
            MessageBox.Show("Saved!");
        }
        
        private void addPicBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;

            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                pb1.Image = Image.FromFile(fileName);
            }
        }

        private void AddScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
