using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Bai6
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

            if (a > b && a > c && a > d)
            {
                if (b > c && b > d)
                {
                    Console.WriteLine($"So {b} la so lon thu hai");
                } else if (c > b && c > d)
                {
                    Console.WriteLine($"So {c} la so lon thu hai");
                } else if (d > b && d > c)
                {
                    Console.WriteLine($"So {d} la so lon thu hai");
                } else
                {
                    Console.WriteLine("Khong co so lon thu hai");
                }
            }
            else if (b > a && b > c && b > d)
            {
                if (a > c && a > d)
                {
                    Console.WriteLine($"So {a} la so lon thu hai");
                }
                else if (c > a && c > d)
                {
                    Console.WriteLine($"So {c} la so lon thu hai");
                }
                else if (d > a && d > c)
                {
                    Console.WriteLine($"So {d} la so lon thu hai");
                } else
                {
                    Console.WriteLine("Khong co so lon thu hai");
                }
            }
            else if (c > b && c > a && c > d)
            {
                if (a > b && a > d)
                {
                    Console.WriteLine($"So {a} la so lon thu hai");
                }
                else if (b > a && b > d)
                {
                    Console.WriteLine($"So {b} la so lon thu hai");
                }
                else if (d > a && d > b)
                {
                    Console.WriteLine($"So {d} la so lon thu hai");
                } else
                {
                    Console.WriteLine("Khong co so lon thu hai");
                }
            }
            else if (d > b && d > c && d > a)
            {
                if (a > b && a > c)
                {
                    Console.WriteLine($"So {a} la so lon thu hai");
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine($"So {b} la so lon thu hai");
                }
                else if (c > a && c > b)
                {
                    Console.WriteLine($"So {c} la so lon thu hai");
                } else
                {
                    Console.WriteLine("Khong co so lon thu hai");
                }
            }
        }
    }
}
