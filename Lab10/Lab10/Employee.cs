 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal abstract class Employee : EmployeeIF
    {
        public string? name;
        public Employee parent;

        public Employee()
        {
            
        }

        public Employee getParent()
        {
            return parent;
        }

        public void seeDanger()
        {

        }

        public void fixIt()
        {
            Console.WriteLine("The person" + name + " is fixing it.");
        }

        public void contactBoss()
        {

        }

        public void evacuate()
        {
            Console.WriteLine("The person " + name + " is evacuating.");
        }
    }
}
