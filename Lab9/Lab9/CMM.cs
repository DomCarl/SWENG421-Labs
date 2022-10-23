/**
 * Jason Cross and Dominick Carlucci
 * CMM.cs class
 * Due Date: 10/23/2022 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
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
        
        public CMM(CoffeeIF cif)
        {
            this.cif = cif;
        }

        public CMM()
        {
            
        }

        public void setCoffeeType(string str)
        {
            if (str.ToUpper() == "ESPRESSO")
            {

                Type t = Type.GetType("Lab9." + str);
                Object o = Activator.CreateInstance(t);
                CoffeeIF cif = (Espresso)o;
                cif = new CoffeeWithStuff(cif, null);
                //cif = new Espresso();
                //cif = new CoffeeWithStuff(cif, null);
                //Console.WriteLine("Making Espresso");
                cif.run();
                //computePrice(cif);
            }
            else if (str.ToUpper() == "LATTE")
            {
                Console.WriteLine("Making Latte");
            }
            else
            {
                Console.WriteLine("Loading " + str);
            }           
        }

        public void setGrindingTime(int sec)
        {
            Console.WriteLine("Grinding for {0} seconds", sec);
        }

        public void addCondiment(CondimentIF type)
        {
             cif = new CoffeeWithStuff(cif, type);
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
            
            //sales.Add(cif);
            //Console.WriteLine(computePrice(cif));
            //Console.WriteLine("Added to sales list" + cif.getPrice());
            
            //foreach (Object o in sales)
            //{
            //    Console.WriteLine(o.GetType());
            //}
        }
    }
}
