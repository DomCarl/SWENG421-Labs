using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class T
    {
        public double price;
        string ID;
        public string name;
        
        T(string ID)
        {
            this.ID = ID;
        }        

        public void setPrice(double price)
        {
            this.price = price;            
        }

        public double getPrice()
        {
            return price;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public string getID()
        {
            return ID;
        }
    }
}
