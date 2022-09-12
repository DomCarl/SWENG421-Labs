using AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Manager: Employee
    {
        public Manager(string name, int age)
        {
            this.setName(name);
            this.setAge(age);
            this.setTitle("Manager");
            this.setSalary(50000);
        }
        public void evaluate(Employee emp, int rating)
        {

        }
    }
}
