using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Bai2
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap chieu rong hinh chu nhat:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chieu dai hinh chu nhat:");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<a; i++)
            {
                for (int j = 0; j<b; j++)
                {
                    if (i == 0 || i == a - 1 || j == 0 || j == b - 1)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write(" \t");
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
