/**
 * Jason Cross and Dominick Carlucci
 * CEO.cs class
 * Due Date: 10/30/22 11:59 p.m.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class CEO : Employee
    {

        public CEO(string name, Employee parent) : base(name, parent)
        { 

        }
        

        public Decision grant(Decision[] da)
        {
            Random rand = new Random();
            int i = rand.Next(2);
            return da[i];
        }

        
        public override string getJobTitle()
        {
            return "CEO";
        }

        public override void notify()
        {
            Console.WriteLine("CEO notified");
            seeDanger();
        }

        public override void seeDanger()
        {            
            Console.WriteLine("CEO is throwing a meeting.");
            
            Decision[] decisions = new Decision[2];
            int n = 0;

            foreach (Employee emp in getSubordinates())
            {
                if (emp.GetType() == typeof(Manager))
                {
                    Manager manager = (Manager)emp;
                    decisions[n] = manager.suggestDecision();
                    n++;
                }
            }
            
            Decision granted = grant(decisions);
            Console.WriteLine(getName() + " (" + getJobTitle() + ") chose the decision from " + granted.getCreator().getName());
            
            granted.doIt();
            
            evacuate();
        }
    }
}
