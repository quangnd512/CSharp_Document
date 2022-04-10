using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Bai20
    {
        static void Input(out int m, out int n, out int[,] array)
        {
            Console.Write("Nhap hang cua ma tran: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap cot cua ma tran: ");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[m, n];
            Console.WriteLine("Nhap gia tri cua ma tran: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Gia tri [{i} , {j}]: ");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void Output(int[,] array)
        {
            Console.WriteLine("Ma tran vua nhap: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void Sum(int [,] array)
        {
            int[] sumCol = new int[10];
            int[] sumRow = new int[10];
            Console.WriteLine("Tong cac hang, cac cot cua ma tran la: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumCol[i] = 0;
                sumRow[i] = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumRow[i] += array[i, j];
                    sumCol[i] += array[j, i];
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.Write($"{sumRow[i]}");
                Console.WriteLine();
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{sumCol[j]}\t");
            }
        }
        static void Main(string[] args)
        {
            int[,] array;
            int m, n;
            Input(out m, out n, out array);
            Output(array);
            Sum(array);
        }
    }
}
