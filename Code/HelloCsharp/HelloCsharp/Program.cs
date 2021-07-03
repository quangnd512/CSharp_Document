using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            float sum = (float)a + b;

            //C1
            Console.WriteLine("a + b = "+sum);

            //C2
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);

            //C3
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}
