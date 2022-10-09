using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal interface AdminIF
    {
        void Save(string name);

        Novel Retrieve(string name);

        Novel View(string name);

        void Edit(string name);

        void Delete(string name);
    }
}
