/**
 * Jason Cross and Dominick Carlucci
 * Manager.cs class
 * Due Date: 10/30/22 11:59 p.m.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Manager : Employee
    {
        private string gatheredInfo = "";

        public Manager(string name, Employee parent) : base(name, parent) 
        { 
            parent.addSubordinate(this); 
        }

        public string getGatheredInfo() 
        { 
            return gatheredInfo; 
        }

        public override string getJobTitle()
        {
            return "Manager";
        }

        public override void seeDanger()
        {
            
            gatheredInfo = "";

            foreach (Supervisor sub in this.getSubordinates())
            {
                gatheredInfo += sub.provideInfo() + "\n";
            }

            Console.WriteLine(getName() + " (" + getJobTitle() + ") gathered the following information from the Supervisors:");

            Console.WriteLine(gatheredInfo);

            
            foreach (Employee sub in this.getSubordinates())
            {
                if (sub.GetType() == typeof(Worker))
                    ((Worker)sub).fixIt();
            }
            
            contactBoss();
        }

        public override void notify()
        {            
            seeDanger();
        }

        public void contactBoss()
        {
            this.getParent().notify();
        }

        public Decision suggestDecision()
        {
            Decision dec = new Decision(this, getName() + "'s (" + getJobTitle() + ") decision is: evacuate.");
            return dec;
        }
    }    
}
