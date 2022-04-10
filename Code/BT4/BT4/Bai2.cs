using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Bai2
    {
        static void Main(string[] args)
        {
            int lenght;
            int[] array;
            Console.Write("Nhap do dai day so: ");
            lenght = Convert.ToInt32(Console.ReadLine());
            array = new int[lenght];
            Console.WriteLine("Nhap cac gia tri cua mang: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap so thu {i+1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Day so vua nhap: ");
            foreach (var item in array)
            {
                Console.Write(item+"\t");
            }
            int min = array[0], max = array[0], min2 = array[0], max2 = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }else if (min > array[i])
                {
                    min = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max || array[i] == min)
                {
                    continue;
                }
                else if (array[i] > max2)
                    {
                        max2 = array[i];
                    }
                    else if (min2 > array[i])
                    {
                        min2 = array[i];
                    }
            }
            Console.WriteLine($"\nSo lon thu 2 trong mang la: {max2}");
            Console.WriteLine($"So nho thu 2 trong mang la: {min2}");
        }
    }
}
