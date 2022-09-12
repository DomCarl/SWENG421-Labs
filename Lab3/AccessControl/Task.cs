using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class Task
 * Dominick Carlucci and Jason Cross
 * Due: 9/11/22
 */

namespace AccessControl
{
    public class Task
    {
        private int ID;
        private string dueDate;
        private string description;

        public Task(int ID, string dueDate, string description)
        {
            this.ID = ID;
            this.dueDate = dueDate;
            this.description = description;
        }

        public int getTaskID()
        {
            return ID;
        }
    }
}
