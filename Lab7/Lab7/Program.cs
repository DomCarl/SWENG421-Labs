/**
 * Jason Cross and Dominick Carlucci
 * Program.cs class
 * Due Date: 10/9/22 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab7
{
    internal static class Program
    {       
        static void Main()
        {
            CompositeNovelIttyBits col1 = new Column();
            CompositeNovelIttyBits col2 = new Column();
            CompositeNovelIttyBits lot1 = new LineOfText();
            CompositeNovelIttyBits lot2 = new LineOfText();
            CompositeNovelIttyBits fr = new Frame();
            CompositeNovelIttyBits p = new Page();
            Novel n = new Novel();
            Writer writer = new Writer();
            

            lot1.al.Add(new Character('S'));
            lot1.al.Add(new Character('W'));
            lot1.al.Add(new Character('E'));
            lot1.al.Add(new Character('N'));
            lot1.al.Add(new Character('G'));

            lot2.al.Add(new Character('4'));
            lot2.al.Add(new Character('2'));
            lot2.al.Add(new Character('1'));
            
            n.al.Add(p);

            p.al.Add(col1);
            p.al.Add(fr);

            fr.al.Add(col2);

            col1.al.Add(lot1);
            col2.al.Add(lot2);

            writer.View(n);
        }
    }
}
