using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Utility
    {
        string sortName;

        Utility()
        {
            this.sortName = "bubblesort";
        }

        Utility(string sortName)
        {
            this.sortName = sortName;
        }

        public string getSortName()
        {
            return sortName;
        }

        public List<T> sort(List<T> data)
        {
            return data;
        }
    }
}
