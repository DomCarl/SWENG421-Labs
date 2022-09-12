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
    }
}
