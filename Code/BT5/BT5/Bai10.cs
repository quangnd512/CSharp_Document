using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Bai10
    {
        static void Input(out int n, ref int[] array)
        {
            Console.Write("Nhap so luong phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Console.Write("Nhap cac phan tu cua mang: \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Output(int[] array)
        {
            Console.Write("Mang vua nhap: ");
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
        }
        static void Sort(int temp, int[] array)
        {
            temp = array[0];
            Console.Write("\nMang sau khi sap xep tang dan: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            Console.Write("\nMang sau khi sap xep giam dan: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
        }
        static void Main(string[] args)
        {
            int[] array = default;
            int n, temp = 0;
            bool a = false;
            do
            {
                Console.WriteLine("1. Nhap phan tu trong mang.");
                Console.WriteLine("2. Sap sep mang.");
                Console.WriteLine("3. Hien thi mang.");
                Console.WriteLine("Lua chon: ");
                int choose;
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: Input(out n, ref array); break;
                    case 2: Sort(temp, array); break;
                    case 3: Output(array); break;
                    default:
                        Console.WriteLine("Lua chon sai.! Vui long nhap lai");
                        break;
                }
            } while (true);
        }
    }
}
