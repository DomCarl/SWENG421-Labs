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

        public void Update(Employee p, int amt)
        {
            p.setSalary(amt);
        }
    }
}
