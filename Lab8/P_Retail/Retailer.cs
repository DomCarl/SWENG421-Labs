/**
 * Jason Cross and Dominick Carlucci
 * Retailer.cs class
 * Due Date: 10/16/22
 */

using P_TV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace P_Retail
{
    public class Retailer
    {
        public TV_Proxy tvp = new TV_Proxy();
        public TV_IF sony_tvif = new Sony_TV();
        public TV_IF visio_tvif = new Visio_TV();        
    }
}
