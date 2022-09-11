using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Accountant: Employee
    {
        private void Update(Employee p, int amt)
        {
            p.setSalary(amt);
        }
    }
}
