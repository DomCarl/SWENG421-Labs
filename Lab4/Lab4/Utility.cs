/*
 * Utility.cs class 
 * Jason Cross and Dominick Carlucci
 * Due Date: September 18 2022 11:59 p.m.
 */

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Utility<T>
    {
        string sortName;

        public Utility()
        {
            this.sortName = "bubblesort";
        }

        public Utility(string sortName)
        {
            this.sortName = sortName;
        }

        public string getSortName()
        {
            return sortName;
        }

        public virtual List<Desk> Sort(List<Desk> data)
        {
            return data;
        }

        public virtual void print(List<Desk> defaultSort)
        {
            
        }
    }
}
