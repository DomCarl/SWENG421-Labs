/**
 * Jason Cross and Dominick Carlucci
 * Decision.cs class
 * Due Date: 10/30/22 11:59 p.m.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Decision
    {
        private Employee emp;
        private string decisionDesc; 
        private Employee creator; 

        public Decision(Employee creator, String desc)
        {
            this.creator = creator;
            this.decisionDesc = desc;
        }

        public Employee getCreator() 
        { 
            return creator; 
        }

        public string getDescription() 
        { 
            return decisionDesc; 
        }

        public void doIt()
        {
            Console.WriteLine("The city's environmental department is notified. All persons must evacuate!");
        }
    }
}
