using AccessControl;
using Lab3;
using System;

namespace MyNamespace
{
    class Lab3Main
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();
            Blacksmith b = new Blacksmith();
            Owner o = new Owner();

            accountant.Update(b, 65000);

            Console.WriteLine(b.getSalary());
        }
    }
}
