using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public struct Recipe
    {
        public string name;
        public string category;
        public string diet;
        public double servings;
        public Dictionary<string, double> ingredients;
        public List<string> units;
        public string image;
        public string instructions;
        public int recipeCount;

        public void setValues(string name, string category, string diet, double servings, Dictionary<string, double> ingredients, List<string> units, string image, string instructions)
        {
            this.name = name;
            this.category = category;
            this.diet = diet;
            this.servings = servings;
            this.ingredients = ingredients;
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
                ingredients.Add(ingredient, amount.Value);
                units.Add(unit);
            }
        end:;
        }
    }
}
