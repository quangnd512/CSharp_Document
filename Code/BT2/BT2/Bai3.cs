using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai3
    {
        static float Split(int m)
        {
            return (float)1 / m;
        }
        static void Main(string[] args)
        {
            int n;
            float sum = 0;
            Console.WriteLine("Nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                sum += Split(i);
            }
            Console.WriteLine($"Ket qua la: {sum}");
        }
    }
}
