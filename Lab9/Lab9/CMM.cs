/**
 * Jason Cross and Dominick Carlucci
 * CMM.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class CMM
    {
        public List<CoffeeIF> sales = new List<CoffeeIF>();
        double sale = 0;
        public int LED_Num = 0;
        CoffeeIF cif;

        public void setCoffeeType(string str)
        {
            Console.WriteLine("Loading " + str);
        }

        public void setGrindingTime(int sec)
        {
            Console.WriteLine("Grinding for {0} seconds", sec);
        }

        void addCondiment(CondimentIF type)
        {
            sale += type.getCharge();
        }

        public void setTemperature(int degree)
        {
            Console.WriteLine("Temperature set to {0} degrees", degree);
        }

        public void setLEDNumber(int num)
        {
            string stringNum = num.ToString();
            string padNum = stringNum.PadLeft(2, '0');
            Console.WriteLine(padNum);
        }

        public double computePrice(CoffeeIF cif)
        {
            return cif.getPrice();
        }
        
        public void done()
        {
            sales.Add(cif);
            Console.WriteLine("Added to sales list" + cif.getPrice());
            
            //foreach (Object o in sales)
            //{
            //    Console.WriteLine(o.GetType());
            //}
        }
    }
}
