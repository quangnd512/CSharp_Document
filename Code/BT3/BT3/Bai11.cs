using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Bai11
    {
        static void Main(string[] args)
        {
            int a=7;
            for (int i = 0; i < a-1; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == 0 && j == 0 || i == 0 && j == 3 || i == 0 && j == 6 || 
                        i == 3 && j == 0 || i == 3 && j == 6 ||
                        i == 4 && j == 0 || i == 4 && j == 6 || i == 4 && j == 1 || i == 4 && j == 5 ||
                        i == 5 && Math.Abs(i-j) != 2 )
                    {
                        Console.Write(" \t");
                    }
                    else { 
                        Console.Write("*\t");
                    }
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
