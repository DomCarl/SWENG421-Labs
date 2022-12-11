using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class LoadFromUSB
    {
        RecipeFilterIF rif;

        public void Grab()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Dom\Documents\GitHub\SWENG421-Labs\Final-Project\Final-Project\SampleImport.txt");

            FormManager.adds.nameTB.Text = lines[0];
            FormManager.adds.typeCB.Text = lines[1];
            FormManager.adds.dietCB.Text = lines[2];
            FormManager.adds.servingsTB.Text = lines[3];
            FormManager.adds.ingTB1.Text = lines[4];
            FormManager.adds.amtTB1.Text = lines[5];
            FormManager.adds.unitTB1.Text = lines[6];
            FormManager.adds.ingTB2.Text = lines[7];
            FormManager.adds.amtTB2.Text = lines[8];
            FormManager.adds.unitTB2.Text = lines[9];
            FormManager.adds.ingTB3.Text = lines[10];
            FormManager.adds.amtTB3.Text = lines[11];
            FormManager.adds.unitTB3.Text = lines[12];
        }
    }
}
