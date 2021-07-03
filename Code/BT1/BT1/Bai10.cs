using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Bai10
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    float x;
                    Console.WriteLine($"Phuong trinh bac 1 co dang: {b}.x + {c} = 0");
                    x = (float)-c / b;
                    Console.WriteLine($"Nghiem cua phuong trinh la: x = {x}");
                }
            }else if (a != 0)
            {
                float delta, x12, x1, x2;
                Console.WriteLine($"Phuong trinh bac hai co dang: {a}.x^2 + {b}.x + {c} = 0");
                delta = (float)b * b - (4 * a * c);
                x12 = (float)-b / 2 * a;
                x1 = (float)(-b+Math.Sqrt(delta))/(2*a);
                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                if (delta > 0)
                {
                    Console.WriteLine($"Phuong trinh co hai nghiem: x1 = {x1} , x2 = {x2}");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"Phuong trinh co mot nghiem: x1 = x2 = {x12}");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }

            }
        }
    }
}
