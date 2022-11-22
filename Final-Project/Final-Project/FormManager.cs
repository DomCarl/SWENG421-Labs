using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    static class FormManager
    {
        public static mainMenu mm = new mainMenu();
        public static ViewScreen vs = new ViewScreen();
        public static AddScreen adds = new AddScreen();
        public static RecipeCalc rc = new RecipeCalc();
        public static SearchScreen ss = new SearchScreen();
        public static Categories cs = new Categories();
        public static DietPlans dp = new DietPlans();
        public static MakeAMeal mam = new MakeAMeal();               
    }
}
