using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Bai5
    {
        static void Main(string[] args)
        {
            int a, b, c, d; 
            Console.WriteLine("Nhap so thu nhat:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu ba:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu tu:");
            d = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c && a < d)
            {
                Console.WriteLine($"So {a} la so nho nhat");
            }else if (a > b && a < c && a < d)
            {
                Console.WriteLine($"So {b} la so nho nhat");
            }
            else if (a < b && a > c && a < d)
            {
                Console.WriteLine($"So {c} la so nho nhat");
            }
            else if (a < b && a < c && a > d)
            { 
                Console.WriteLine($"So {d} la so nho nhat");
            }
            else
            {
                Console.WriteLine("Khong co so nho nhat");
            }
        }
    }
}
