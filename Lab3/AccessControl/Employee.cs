using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public abstract class Employee
    {
        private string name;
        private int age;
        private string title;
        private int salary;

        internal void setSalary(int amt)
        {
            salary = amt;
        }

        public void send(Employee p, Employee o, string message)
        {
            Console.WriteLine(o.name + " is sending " + p.name + " a message: " + message);
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public string getTitle()
        {
            return title;
        }

        public int getSalary()
        {
            return salary;
        }
    }
}
