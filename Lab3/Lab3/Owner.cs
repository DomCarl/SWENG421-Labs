/*
 * Class Owner
 * Dominick Carlucci and Jason Cross
 * Due: 9/11/22
 */

using AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccessControl
{
    public class Owner: Employee
    {
       public Owner(int age)
        {
            this.setName("Craig");
            this.setAge(age);
            this.setTitle("Owner");
        }

        public override void Send(string message, Employee emp)
        {
            Console.WriteLine(this.getName() + " is sending a message to " + emp.getName());
            Console.WriteLine(message);
        }
    }
}
