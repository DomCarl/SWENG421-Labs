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
    public partial class ViewScreen : Form
    {
        public List<LinkLabel> entreelinks = ListManager.entreeLinkLabels;
        public List<LinkLabel> sidelinks = ListManager.sideLinkLabels;
        public List<LinkLabel> dessertlinks = ListManager.dessertLinkLabels;
        public List<LinkLabel> snacklinks = ListManager.snackLinkLabels;

        public ViewScreen()
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

        private void ViewScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }            
            
            var rec = ListManager.entreeList.Find(x => x.name == linkLabel1.Text);
            FormManager.adds.displayRecipe(rec);            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel2.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel3.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel4.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel5.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel6.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel7.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel8.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel9.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.entreeList.Find(x => x.name == linkLabel10.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel11.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel12.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel13.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel14.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel15.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel16.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel17.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel18.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel19.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.sideList.Find(x => x.name == linkLabel20.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel21.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel22.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel23.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel24.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel25.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel26.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel27.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel28.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel29_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel29.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.dessertList.Find(x => x.name == linkLabel30.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel31.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel32.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel33_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel33.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel34_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel34.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel35_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel35.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel36_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel36.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel37_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel37.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel38_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel38.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel39_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel39.Text);
            FormManager.adds.displayRecipe(rec);
        }

        private void linkLabel40_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                entreelinks[i].Visible = false;
                sidelinks[i].Visible = false;
                dessertlinks[i].Visible = false;
                snacklinks[i].Visible = false;
            }

            var rec = ListManager.snackList.Find(x => x.name == linkLabel40.Text);
            FormManager.adds.displayRecipe(rec);
        }
    }
}
