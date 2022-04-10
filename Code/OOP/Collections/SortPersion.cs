using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SortPersion : IComparer
    {
        public int Compare(object x, object y)
        {
            Persion p1 = x as Persion;
            Persion p2 = y as Persion;

            if (p1 == null || p2 == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                if (p1.Age < p2.Age)
                {
                    return -1;
                }else if (p1.Age == p2.Age)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
