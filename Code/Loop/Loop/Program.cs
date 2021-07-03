using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                else if (i == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
