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
            Application.Exit();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Recipe r = new Recipe();
            r.setValues(nameTB.Text, typeCB.SelectedItem.ToString(), dietCB.SelectedItem.ToString(), Convert.ToDouble(servingsTB.Text), new List<string>(), new List<double>(), new List<string>(), fileName, dirTB.Text);

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
            
            switch(r.category)
            {
                case "Entree":
                    ListManager.entreeList.Add(r);
                    break;
                case "Side Dish":
                    ListManager.sideList.Add(r);
                    break;
                case "Dessert":
                    ListManager.dessertList.Add(r);
                    break;
                case "Snack":
                    ListManager.snackList.Add(r);
                    break;
                default:
                    break;
            }                
            
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

        public void displayRecipe(Recipe r)
        {
            FormManager.vs.Hide();
            FormManager.adds.Show();
            nameTB.Text = r.name;
            typeCB.SelectedItem = r.category;
            dietCB.SelectedItem = r.diet;
            servingsTB.Text = r.servings.ToString();
            dirTB.Text = r.instructions;
            fileName = r.image;
            pb1.Image = Image.FromFile(fileName);

            for (int i = 0; i < r.ingredients.Count; i++)
            {
                if (r.ingredients[i] != null)
                {
                    switch (i)
                    {
                        case 0:
                            ingTB1.Text = r.ingredients[i];
                            amtTB1.Text = r.amounts[i].ToString();
                            unitTB1.Text = r.units[i];
                            break;
                        case 1:
                            ingTB2.Text = r.ingredients[i];
                            amtTB2.Text = r.amounts[i].ToString();
                            unitTB2.Text = r.units[i];
                            break;
                        case 2:
                            ingTB3.Text = r.ingredients[i];
                            amtTB3.Text = r.amounts[i].ToString();
                            unitTB3.Text = r.units[i];
                            break;
                        case 3:
                            ingTB4.Text = r.ingredients[i];
                            amtTB4.Text = r.amounts[i].ToString();
                            unitTB4.Text = r.units[i];
                            break;
                        case 4:
                            ingTB5.Text = r.ingredients[i];
                            amtTB5.Text = r.amounts[i].ToString();
                            unitTB5.Text = r.units[i];
                            break;
                        case 5:
                            ingTB6.Text = r.ingredients[i];
                            amtTB6.Text = r.amounts[i].ToString();
                            unitTB6.Text = r.units[i];
                            break;
                        case 6:
                            ingTB7.Text = r.ingredients[i];
                            amtTB7.Text = r.amounts[i].ToString();
                            unitTB7.Text = r.units[i];
                            break;
                        case 7:
                            ingTB8.Text = r.ingredients[i];
                            amtTB8.Text = r.amounts[i].ToString();
                            unitTB8.Text = r.units[i];
                            break;
                        case 8:
                            ingTB9.Text = r.ingredients[i];
                            amtTB9.Text = r.amounts[i].ToString();
                            unitTB9.Text = r.units[i];
                            break;
                        case 9:
                            ingTB10.Text = r.ingredients[i];
                            amtTB10.Text = r.amounts[i].ToString();
                            unitTB10.Text = r.units[i];
                            break;
                        case 10:
                            ingTB11.Text = r.ingredients[i];
                            amtTB11.Text = r.amounts[i].ToString();
                            unitTB11.Text = r.units[i];
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
