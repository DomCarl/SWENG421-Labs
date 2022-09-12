using AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Owner: Employee
    {
        private string name;

        public void send(Employee emp, string message)
        {
            Console.WriteLine(this.name + "is sending " + emp.getName() + " a message: " + message);
        }
    }
}
