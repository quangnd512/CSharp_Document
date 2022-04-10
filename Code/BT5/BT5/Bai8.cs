using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Bai8
    {
        static void HistorycalMath()
        {
            Console.WriteLine("Vua ga vua cho.");
            Console.WriteLine("Bo bai cho tron.");
            Console.WriteLine("Ba muoi sau con.");
            Console.WriteLine("Mot tram chan chan.");
            Console.WriteLine("Hoi co bao nhieu con ga.? Bao nhieu con cho.?.");
        }
        static void Solve()
        {
            Console.WriteLine("Goi so chan ga la: x");
            Console.WriteLine("Goi so chan cho la: y");
            Console.WriteLine("Ga + Cho la: x + y = 36");
            Console.WriteLine("So chan ga + So chan cho la: 2.x + 4.y = 100");
            int x = 72 - 50;
            int y = 36 - x;
            Console.WriteLine($"Voi bai toan tren ta co: x = {x}, y = {y}");
            if (2*x+4*y == 100)
            {
                Console.WriteLine($"So ga la: {x}");
                Console.WriteLine($"So cho la: {y}");
            }
        }
        static void Main(string[] args)
        {
            HistorycalMath();
            Solve();
        }
    }
}
