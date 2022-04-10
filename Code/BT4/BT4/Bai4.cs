using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Bai4
    {
        static void Main(string [] args)
        {
            int n = default, x = default, dem = 0;
            int[] array;
            Console.Write("Nhap so luong cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("Nhap cac phan tu trong mang mang: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Phan tu thu {i+1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Cac phan tu trong mang: ");
            foreach (var item in array)
            {
                Console.Write($"{item} \t");
            }
            Console.Write("\nNhap phan tu muon tim: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==x)
                {
                    dem++;
                }
            }
            if (dem>0)
            {
                Console.WriteLine($"Phan tu {x} xuat hien {dem} lan");
            }
            else
            {
                Console.WriteLine($"Phan tu {x} khong xuat hien trong mang");
            }
        }
    }
}
