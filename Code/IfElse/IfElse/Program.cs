using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable = (dieuKien) ? trongHopTrue : trongHopFalse;

            int a = default, b = default;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int n = a > b ? a : b;
            Console.WriteLine(n);
        }
    }
}
