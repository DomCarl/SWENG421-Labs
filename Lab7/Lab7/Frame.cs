/**
 * Jason Cross and Dominick Carlucci
 * Frame.cs class
 * Due Date: 10/9/22 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Frame : CompositeNovelIttyBits
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
            for (int i = 0; i < al.Count; i++)
            {
                al[i].View();
            }
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
