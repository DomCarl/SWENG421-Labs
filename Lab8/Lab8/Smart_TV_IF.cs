using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public interface Smart_TV_IF : TV_IF
    {
        public Object replenishTV(int budget);        
    }
}
