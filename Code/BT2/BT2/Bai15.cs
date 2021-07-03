using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai15
    {
        static void Main(string[] agrs)
        {
            long n;
            Console.Write("Nhap n: ");
            n = Convert.ToInt64(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                sum += (int)n % 10;
                n /= 10;
            }
            Console.WriteLine($"Tong cac chu so la: {sum}");
        }
    }
}
