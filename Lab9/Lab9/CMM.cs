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
        public int LED_Num = 0;
        CoffeeIF cif;
        
        public CMM(CoffeeIF cif)
        {
            this.cif = cif;
        }

        public CMM()
        {
            
        }

        public Object setCoffeeType(string str)
        {
            if (str.ToUpper() == "ESPRESSO")
            {
                Console.WriteLine("Loading " + str);

                Type t = Type.GetType("Lab9." + str);
                Object o = Activator.CreateInstance(t, this);
                
                cif = (Espresso)o;
                return cif;

                
            }
            else if (str.ToUpper() == "LATTE")
            {
                Console.WriteLine("Making Latte");
                return null;
            }
            else
            {
                Console.WriteLine("Loading " + str);
                return null;
            }           
        }

        public void setGrindingTime(int sec)
        {
            Console.WriteLine("Grinding for {0} seconds", sec);
        }
        
        public Object addCondiment(CondimentIF type)
        {
            cif = new CoffeeWithStuff(cif, type);

            return cif;
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

        public double computePrice(CoffeeIF c)
        {
            return c.getPrice();
        }
        
        public void done(string str)
        {            
            Console.WriteLine("Finished making " + str);
                        
            Console.WriteLine("Number of items in List is now: " + sales.Count());            
        }
    }
}
