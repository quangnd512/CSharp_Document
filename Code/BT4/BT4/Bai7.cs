using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Bai7
    {
        static void Main(string[] args)
        {
            int n = default, a = default, b = default, sum = 0;
            int[] array;
            Console.Write("Nhap so luong cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("Nhap cac phan tu trong mang mang: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Phan tu thu {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Cac phan tu trong mang: ");
            foreach (var item in array)
            {
                Console.Write($"{item} \t");
            }
            Console.Write("\nNhap so bat dau cua day so: ");
            a = Convert.ToInt32(Console.ReadLine());
            while(a>b)
            {
                Console.Write("\nNhap so ket thuc cua day so: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (a<b)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }    
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= a && array[i] <= b)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Tong cua cac phan tu trong mang tu {a} den {b} la: {sum}");
        }
    }
}
