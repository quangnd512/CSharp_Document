using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai5
    {
        static double Mutil(int n)
        {
            double mul = 1;
            for (int i = 1; i<=n; i++)
            {
                mul *= i;
            }
            return mul;
        }
        static void Main(string[] args)
        {
            int n;
            double sum = 0;
            Console.WriteLine("Nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum += Mutil(i);
            }
            Console.WriteLine($"Ket qua la: {sum}");
        }
    }
}
