using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Task
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
    }
}
