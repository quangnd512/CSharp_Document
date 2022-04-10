using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Bai2
    {
        static bool Prime(int n)
        {
            int dem = 0;
            if (n<2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n) ; i++)
                {
                    if (n%i==0)
                    {
                        dem++;
                    }
                }
                if (dem == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            int n, dem = 0;
            Console.Write("Nhap so day so nguyen to dau tien: ");
            n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (n>dem)
            {
                if (Prime(i))
                {
                    Console.Write(i+"\t");
                    dem++;
                }
                i++;

            }
        }
    }
}
