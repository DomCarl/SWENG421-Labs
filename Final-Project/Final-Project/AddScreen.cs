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
            
            if (ingTB1.Text == "" || amtTB1.Text == "" || unitTB1.Text == "")
            {
                MessageBox.Show("Please fill out fields for recipe.");
            }
            else
            {
                Recipe r = new Recipe();
                r.setValues(nameTB.Text, typeCB.SelectedItem.ToString(), dietCB.SelectedItem.ToString(), Convert.ToDouble(servingsTB.Text), new List<string>(), new List<double>(), new List<string>(), fileName, dirTB.Text);


                if (ingTB1.Text != "" && amtTB1.Text != "" && unitTB1.Text != "")
                {
                    r.addIngredients(ingTB1.Text, Convert.ToDouble(amtTB1.Text), unitTB1.Text);
                }
                else
                {
                    MessageBox.Show("Please enter an ingredient, amount, and unit.");
                }

                if (ingTB2.Text != "" && amtTB2.Text != "" && unitTB2.Text != "")
                {
                    r.addIngredients(ingTB2.Text, Convert.ToDouble(amtTB2.Text), unitTB2.Text);
                }

                if (ingTB3.Text != "" && amtTB3.Text != "" && unitTB3.Text != "")
                {
                    r.addIngredients(ingTB3.Text, Convert.ToDouble(amtTB3.Text), unitTB3.Text);
                }

                if (ingTB4.Text != "" && amtTB4.Text != "" && unitTB4.Text != "")
                {
                    r.addIngredients(ingTB4.Text, Convert.ToDouble(amtTB4.Text), unitTB4.Text);
                }

                if (ingTB5.Text != "" && amtTB5.Text != "" && unitTB5.Text != "")
                {
                    r.addIngredients(ingTB5.Text, Convert.ToDouble(amtTB5.Text), unitTB5.Text);
                }

                if (ingTB6.Text != "" && amtTB6.Text != "" && unitTB6.Text != "")
                {
                    r.addIngredients(ingTB6.Text, Convert.ToDouble(amtTB6.Text), unitTB6.Text);
                }

                if (ingTB7.Text != "" && amtTB7.Text != "" && unitTB7.Text != "")
                {
                    r.addIngredients(ingTB7.Text, Convert.ToDouble(amtTB7.Text), unitTB7.Text);
                }

                if (ingTB8.Text != "" && amtTB8.Text != "" && unitTB8.Text != "")
                {
                    r.addIngredients(ingTB8.Text, Convert.ToDouble(amtTB8.Text), unitTB8.Text);
                }

                if (ingTB9.Text != "" && amtTB9.Text != "" && unitTB9.Text != "")
                {
                    r.addIngredients(ingTB9.Text, Convert.ToDouble(amtTB9.Text), unitTB9.Text);
                }

                if (ingTB10.Text != "" && amtTB10.Text != "" && unitTB10.Text != "")
                {
                    r.addIngredients(ingTB10.Text, Convert.ToDouble(amtTB10.Text), unitTB10.Text);
                }

                if (ingTB11.Text != "" && amtTB11.Text != "" && unitTB11.Text != "")
                {
                    r.addIngredients(ingTB11.Text, Convert.ToDouble(amtTB11.Text), unitTB11.Text);
                }                            

                switch (r.category)
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
            if (fileName != null)
            {
                pb1.Image = Image.FromFile(fileName);
            }
            else
            {
                pb1.Image = null;
            }            

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

        private void aboutMI_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void addIng1_Click(object sender, EventArgs e)
        {
            addIng1.Visible = false;
            ingTB4.Visible = true;
            amtTB4.Visible = true;
            unitTB4.Visible = true;
            addIng2.Visible = true;
        }

        private void addIng2_Click(object sender, EventArgs e)
        {
            addIng2.Visible = false;
            ingTB5.Visible = true;
            amtTB5.Visible = true;
            unitTB5.Visible = true;
            addIng3.Visible = true;
        }

        private void addIng3_Click(object sender, EventArgs e)
        {
            addIng3.Visible = false;
            ingTB6.Visible = true;
            amtTB6.Visible = true;
            unitTB6.Visible = true;
            addIng4.Visible = true;
        }

        private void addIng4_Click(object sender, EventArgs e)
        {
            addIng4.Visible = false;
            ingTB7.Visible = true;
            amtTB7.Visible = true;
            unitTB7.Visible = true;
            addIng5.Visible = true;
        }

        private void addIng5_Click(object sender, EventArgs e)
        {
            addIng5.Visible = false;
            ingTB8.Visible = true;
            amtTB8.Visible = true;
            unitTB8.Visible = true;
            addIng6.Visible = true;
        }

        private void addIng6_Click(object sender, EventArgs e)
        {
            addIng6.Visible = false;
            ingTB9.Visible = true;
            amtTB9.Visible = true;
            unitTB9.Visible = true;
            addIng7.Visible = true;
        }

        private void addIng7_Click(object sender, EventArgs e)
        {
            addIng7.Visible = false;
            ingTB10.Visible = true;
            amtTB10.Visible = true;
            unitTB10.Visible = true;
            addIng8.Visible = true;
        }

        private void addIng8_Click(object sender, EventArgs e)
        {
            addIng8.Visible = false;
            ingTB11.Visible = true;
            amtTB11.Visible = true;
            unitTB11.Visible = true;
        }

        private void saveCBMI_Click(object sender, EventArgs e)
        {
            ListManager.SerializeLists();
            MessageBox.Show("Cookbook saved!");
        }

        private void printMI_Click(object sender, EventArgs e)
        {

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
    }
}
