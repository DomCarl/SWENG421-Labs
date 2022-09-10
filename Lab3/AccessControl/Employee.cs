using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Employee
    {
        public string name;
        public int age;
        public string title;
        int salary;

        internal void setSalary(int amt)
        {
            salary = amt;
        }

        public int getSalary()
        {
            return salary;
        }
    }
}
