using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ComparerUnitPrice : IComparer<Item>
    {
        public int Compare(Item elem1, Item elem2)
        {
            float un1 = elem1.unitPrice;
            float un2 = elem2.unitPrice;

            if (un1 < un2)
            {
                return 1;
            }
            else if (un1 > un2)
            {
                return -1;
            }

            return 0;
        }
        }
}
