using System;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(5);
            list.Add(8);
            list.Add(3);
            Console.WriteLine(list[1]);
        }
    }
}
