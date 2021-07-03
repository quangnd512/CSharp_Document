using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Bai4
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhap canh cua tam giac");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i>j)
                    {
                        Console.Write("*\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
