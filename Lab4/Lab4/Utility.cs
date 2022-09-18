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
            int num = data.Count;

            for(int i = 0; i < num - 1; i++)
            {
                for(int j = 0; j < num - i - 1; j++)
                {
                    if (data[j].price > data[j + 1].price)
                    {
                        Desk temp = data[j];

                        data[j] = data[j + 1];

                        data[j + 1] = temp;
                    }
                }
            }

            return data;
        }
    }
}
