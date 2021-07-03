using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai12
    {
        static int Fibol(int n)
        {
            if (n<1)
            {
                return 0;
            }else if (n==1)
            {
                return 1;
            }
            return Fibol(n - 1) + Fibol(n - 2);
        }
        static void Main(string[] agrs)
        {
            int n;
            Console.Write("Nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day so fibonacci: ");
            int i = 0, dem = 0;
            while (dem < n)
            {
                Console.Write($"{Fibol(i)}\t");
                i++;
                dem++;
            }
        }
    }
}
