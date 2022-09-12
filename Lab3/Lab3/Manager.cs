/*
 * Class Manager
 * Dominick Carlucci and Jason Cross
 * Due: 9/11/22
 */

using AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
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

        public override void evaluate(Employee emp, int rating)
        {
            Console.WriteLine(this.getName() + " evaluated " + emp.getName() + " with a score of " + rating);
        }

        public override void Delegate(Employee emp, Employee emp2, int rating)
        {
            emp.evaluate(emp2, rating);
        }
    }
}
