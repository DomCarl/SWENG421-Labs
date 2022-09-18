/*
 * Desk.cs class 
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
    public class Desk: ProductIF
    {
        private int ID;
        public string name;
        public double price;
        
        public Desk(int ID)
        {
            this.ID = ID;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getID()
        {
            return ID;
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }              
    }
}
