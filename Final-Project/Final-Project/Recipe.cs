using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    [Serializable]
    public class Recipe
    {
        public string name;
        public string category;
        public string diet;
        public double servings;
        public List<string> ingredients;
        public List<double> amounts;
        public List<string> units;
        public string image;
        public string instructions;        

        public void setValues(string name, string category, string diet, double servings, List<string> ingredients, List<double> amounts, List<string> units, string image, string instructions)
        {
            this.name = name;
            this.category = category;
            this.diet = diet;
            this.servings = servings;
            this.ingredients = ingredients;
            this.amounts = amounts;
            this.units = units;
            this.image = image;
            this.instructions = instructions;
        }

        public string getRecipe(string name)
        {
            return this.name;
        }

        public void addIngredients(string ingredient, double? amount, string unit)
        {
            if (ingredient == "Ingredient")
            {
                goto end;
            }
            else
            {
                ingredients.Add(ingredient);
                amounts.Add(amount.Value);
                units.Add(unit);
            }
        end:;
        }
    }
}
