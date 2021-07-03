using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai14
    {
        static void Main(string[] agrs)
        {
            int n, multi = 1;
            Console.Write("Nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.Write($"Tich cua giai thua = {1}");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    multi *= i;
                }
                Console.WriteLine($"Tich cua giai thua = {multi}");
            }
        }
    }
}
