using AccessControl;
using Lab3;
using System;

namespace MyNamespace
{
    class Lab3Main
    {
        static void Main(string[] args)
        {
            Employee jane = new Accountant("Jane", 45);
            Employee joe = new Accountant("Joe", 56);

            Employee john = new Manager("John", 28);
            Employee mary = new Manager("Mary", 32);
        }
    }
}
