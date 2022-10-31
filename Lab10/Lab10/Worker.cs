/**
 * Jason Cross and Dominick Carlucci
 * Worker.cs class
 * Due Date: 10/30/22 11:59 p.m.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Worker : Employee
    {
        public Worker(string name, Employee parent) : base(name, parent) { parent.addSubordinate(this); }
        public override void fixIt()
        {
            Console.WriteLine("The person " + getName() + " is fixing it.");
        }
        public override string getJobTitle()
        {
            return "Worker";
        }
        public override void seeDanger()
        {            
            Console.WriteLine(getName() + " (" + getJobTitle() + ") sees a gas leak!");
            
            this.getParent().notify();
        }
        public override void notify()
        {            
            return;
        }
    }
}
