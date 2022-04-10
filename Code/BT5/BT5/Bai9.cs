using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Bai9
    {
        static double ShowNumber(double n)
        {
            int i =0;
            while (n>0)
            {
                i = (int)n % 10;
                if (i>=0)
                {
                    n = Math.Floor(n/10);
                    continue;
                }
            }
            return i;

        }
        static void Main(string[] args)
        {
            double n;
            Console.Write("Nhap so can kiem tra: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Cho so dau tien cua so {n} la: {ShowNumber(n)}");
        }
    }
}
