/**
 * Jason Cross and Dominick Carlucci
 * Employee.cs class
 * Due Date: 10/30/22 11:59 p.m.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal abstract class Employee
    {
        private string name;
        private List<Employee> subordinates; 
        private Employee parent; 
        public Employee(string name, Employee parent)
        {
            this.name = name;
            this.parent = parent;
            this.subordinates = new List<Employee>();
        }
        public string getName()
        {
            return this.name;
        }

        public Employee getParent()
        { 
            return this.parent;
        }

        public List<Employee> getSubordinates()
        { 
            return this.subordinates; 
        }

        public void addSubordinate(Employee sub) 
        {
            subordinates.Add(sub);
        }

        public virtual void seeDanger()
        { 

        }

        public virtual void fixIt() 
        { 

        }

        public virtual string getJobTitle() 
        { 
            return ""; 
        }

        public virtual void notify() 
        {
            
        }

        public void evacuate()
        {            
            foreach (Employee emp in getSubordinates())
                emp.evacuate();
            Console.WriteLine("The person " + getName() + " is evacuating");
        }
    }
}
