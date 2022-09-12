using AccessControl;
using Lab3;
using System;

namespace MyNamespace
{
    class Lab3Main
    {
        static void Main(string[] args)
        {
            Employee acc = new Accountant();

            Console.WriteLine(acc.getName());
        }
    }
}
