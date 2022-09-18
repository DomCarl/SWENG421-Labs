/*
 * XYZ.cs class 
 * Jason Cross and Dominick Carlucci
 * Due Date: September 18 2022 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Lab4
{
    internal class XYZ
    {
        public static void Main(string[] args)
        {
            List<Desk> desks = new List<Desk>();

            desks.Add(new Desk(1) { name = "Desk 1", price = 20.30 });
            desks.Add(new Desk(2) { name = "Desk 2", price = 15.25 });
            desks.Add(new Desk(3) { name = "Desk 3", price = 25.13 });
            desks.Add(new Desk(4) { name = "Desk 4", price = 5.85 });

            Utility<Desk> first = new UtilityBubblesort<Desk>();

            List<Desk> defaultSort = first.Sort(desks);

            first.print(defaultSort);

            Utility<Desk> utility = new UtilityQuicksort<Desk>();

            List<Desk> quickSortList = utility.Sort(desks);

            utility.print(quickSortList);
        }
    }
}
