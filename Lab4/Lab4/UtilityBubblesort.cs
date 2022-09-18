/*
 * UtilityBubblesort.cs class 
 * Jason Cross and Dominick Carlucci
 * Due Date: September 18 2022 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class UtilityBubblesort<T> : Utility<T>
    {
        public override List<Desk> Sort(List<Desk> data)
        {
            int num = data.Count;

            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
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

        public override void print(List<Desk> list)
        {
            foreach (Desk desk in list)
            {
                Console.WriteLine(desk.getID() + " " + desk.name + " " + desk.price);
            }
        }
    }
}
