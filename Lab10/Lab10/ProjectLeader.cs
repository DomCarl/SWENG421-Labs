/**
 * Jason Cross and Dominick Carlucci
 * Project Leader.cs class
 * Due Date: 10/30/22 11:59 p.m.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class ProjectLeader : Employee
    {
        public ProjectLeader(string name, Employee parent) : base(name, parent) 
        { 
            parent.addSubordinate(this); 
        }

        public override void fixIt()
        {
            return;
        }

        public override string getJobTitle()
        {
            return "Project Leader";
        }

        public override void seeDanger()
        {
            this.getParent().notify();

            foreach (Employee sub in this.getSubordinates())
            {
                if (sub.GetType() == typeof(Worker))
                    ((Worker)sub).fixIt();
            }
        }

        public override void notify()
        {
            return;
        }

        public string provideInfo()
        {
            return "Information from " + getName() + " (" + getJobTitle() + ")";
        }
    }
}
