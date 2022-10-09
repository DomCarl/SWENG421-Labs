using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Column : CompositeNovelIttyBits
    {
        List<NovelIttyBitsIF> al = new List<NovelIttyBitsIF>();

        public void Save()
        {
            Console.WriteLine("Saving!");
        }

        public void Retrieve()
        {
            Console.WriteLine("Retrieving!");
        }

        public void View()
        {
            Console.WriteLine();
        }

        public void Edit()
        {
            Console.WriteLine("Editing!");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting!");
        }
    }
}
