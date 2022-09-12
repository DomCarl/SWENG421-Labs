/*
 * Class Blacksmith
 * Dominick Carlucci and Jason Cross
 * Due: 9/11/22
 */

using AccessControl;
using Task = AccessControl.Task;

namespace Lab3
{

    class Blacksmith : Employee
    {
        public Blacksmith(string name, int age)
        {
            this.setName(name);
            this.setAge(age);
            this.setTitle("Blacksmith");
            this.setSalary(35000);
        }

        public Blacksmith()
        {

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
