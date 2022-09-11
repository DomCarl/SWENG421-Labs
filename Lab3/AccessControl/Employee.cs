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

        private void setSalary(int amt)
        {
            salary = amt;
        }

        public int getSalary()
        {
            return salary;
        }

        public void send(Employee p, string message)
        {
            Console.WriteLine(Owner.name + " is sending " + p.name + " a message: " + message);
        }
    }
}
