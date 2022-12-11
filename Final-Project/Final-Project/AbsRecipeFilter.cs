using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public abstract class AbsRecipeFilter: RecipeFilterIF
    {
        RecipeFilterIF rfif;
        
        public AbsRecipeFilter(RecipeFilterIF rfif)
        {
            this.rfif = rfif;
        }

        public  Form getForm()
        {
            return null;
        }
    }
}
