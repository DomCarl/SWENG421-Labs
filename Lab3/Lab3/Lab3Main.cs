using AccessControl;
using System;

namespace MyNamespace
{
    class Lab3Main
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();
            Blacksmith b = new Blacksmith();

            accountant.Update(b, 65000);

            Console.WriteLine(b.getSalary());
        }
    }
}
