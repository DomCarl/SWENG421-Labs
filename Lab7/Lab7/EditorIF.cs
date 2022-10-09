using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal interface EditorIF
    {
        void Save(string name);

        Novel Retrieve(string name);

        void Delete(string name);
    }
}
