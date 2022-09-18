using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class UtilityQuicksort<T>: Utility<T>
    {        
        public override List<Desk> Sort(List<Desk> list)
        {
            if (list.Count <= 1) return list;
            int pivotPosition = list.Count / 2;
            Desk pivotValue = list[pivotPosition];
            list.RemoveAt(pivotPosition);
            List<Desk> smaller = new List<Desk>();
            List<Desk> greater = new List<Desk>();
            foreach (Desk item in list)
            {
                if (item.getID() < pivotValue.getID())
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            List<Desk> sorted = Sort(smaller);
            sorted.Add(pivotValue);
            sorted.AddRange(Sort(greater));
            return sorted;
        }
    }
}
