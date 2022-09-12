/*
 * Class Employee
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
    public abstract class Employee
    {
        private string name;
        private int age;
        private string title;
        private int salary;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public int getSalary()
        {
            return salary;
        }

        public void setSalary(int amt)
        {
            this.salary = amt;
        }

        public virtual void Send(string message, Employee emp)
        {

        }

        public virtual void evaluate(Employee emp, int rating)
        {

        }

        public virtual void Delegate(Employee emp, Task t)
        {

        }

        public virtual void Delegate(Employee emp, Employee emp2, int rating)
        {

        }

        public virtual void perform(Task t)
        {

        }

        public virtual void Update(Employee emp, int raise)
        {

        }
    }
}
