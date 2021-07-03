using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Bai9
    {
        static void Main(string[] args)
        {
            int a, k;
            Console.Write("Nhap canh cua tam giac can: ");
            a = Convert.ToInt32(Console.ReadLine());
            k = 2 * a - 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    int h = Math.Abs(a - (j + 1));
                    //Console.WriteLine(h);
                    if (h <= i)
                    {
                        Console.Write($"{i-h+1}\t");
                    }
                    else
                    {
                        Console.Write(" \t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
