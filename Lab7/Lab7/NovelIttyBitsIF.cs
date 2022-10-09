/**
 * Jason Cross and Dominick Carlucci
 * NovelIttyBitsIF.cs class
 * Due Date: 10/9/22 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal interface NovelIttyBitsIF: NovelBitsIF
    {
        void Save();
        

        void Retrieve();


        void View();


        void Edit();
        

        void Delete();        
    }
}
