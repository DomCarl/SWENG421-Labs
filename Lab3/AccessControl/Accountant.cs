/*
 * Class Accountant
 * Dominick Carlucci and Jason Cross
 * Due: 9/11/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Accountant: Employee
    {

        public Accountant(string name, int age)
        {
            this.setName(name);
            this.setAge(age);
            this.setTitle("Accountant");
            this.setSalary(45000);
        }

        public Accountant()
        {

        }

        public override void Update(Employee p, int amt)
        {
            p.setSalary(amt);
            Console.WriteLine(p.getName() + "'s salary is updated to: " + p.getSalary());
        }

        public override void perform(Task t)
        {
            Console.WriteLine(this.getName() + " is performing " + t.getTaskID());
        }

        public override void Delegate(Employee emp, Task t)
        {
            emp.perform(t);
        }
    }
}
