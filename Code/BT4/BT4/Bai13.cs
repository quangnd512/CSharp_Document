using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Bai13
    {
        static void Main(string[] args)
        {
            int n = default, delete = default;
            bool isTrue = false;
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
            while (isTrue == false)
            {
                Console.Write("\nNhap vi tri phan tu muon xoa: ");
                delete = Convert.ToInt32(Console.ReadLine());
                if (delete>n || delete < 0)
                {
                    isTrue = false;
                }
                else
                {
                    isTrue = true;
                    break;
                }
            }
            for (int i = delete-1; i < array.Length - 1; i++)
            {
                array[i] = array[i+1];
            }
            Console.WriteLine("Cac phan tu trong mang sau khi xoa: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]} \t");
            }
        }
    }
}
