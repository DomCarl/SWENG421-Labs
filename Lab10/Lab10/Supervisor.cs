/**
 * Jason Cross and Dominick Carlucci
 * Supervisor.cs class
 * Due Date: 10/30/22 11:59 p.m.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Supervisor : Employee
    {
        public Supervisor(string name, Employee parent) : base(name, parent) { parent.addSubordinate(this); }
        public override void fixIt()
        {
            Console.WriteLine("The person " + getName() + " is fixing it.");
        }
        public override string getJobTitle()
        {
            return "Supervisor";
        }
        public override void seeDanger()
        {
            foreach (Employee sub in this.getSubordinates())
            {
                if (sub.GetType() == typeof(Worker))
                    ((Worker)sub).fixIt();
            }

            this.getParent().notify();
        }
        public override void notify()
        {
            seeDanger();
        }
        public string provideInfo()
        {
            return "Information from " + getName() + " (" + getJobTitle() + ")";
        }
    }
}
