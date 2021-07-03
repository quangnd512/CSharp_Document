using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai10
    {
        static bool Nt(int n)
        {
            if (n<=1)
            {
                return false;
            }
            else
            {
                for (int i =2; i<=Math.Sqrt(n);i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            int n;
            double sum = 0;
            Console.WriteLine("Nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac thua so nguyen to la: ");
            for (int i = 2; i <= n; i++)
            {
                while (n%i==0 && Nt(i))
                {
                    Console.Write($"{i}\t");
                    n /= i;
                }
            }
            Console.WriteLine();
        }
    }
}
