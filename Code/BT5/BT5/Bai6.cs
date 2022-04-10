using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Bai6
    {
        static int Fibonacci(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 0;
            }else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so day so fibonacci dau tien: ");
            n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (n > i)
            {
                Console.Write(Fibonacci(i) + "\t");
                i++;

            }
        }
    }
}
