using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            arr.Add(new Persion("Nguyen van A", 20));
            arr.Add(new Persion("Nguyen van B", 18));
            arr.Add(new Persion("Nguyen van C", 25));

            //Sap xep
            arr.Sort(new SortPersion());
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
