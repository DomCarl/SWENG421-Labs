using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class CompositeNovelIttyBits: NovelIttyBitsIF
    {
        public List<NovelIttyBitsIF> al = new List<NovelIttyBitsIF>();

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
