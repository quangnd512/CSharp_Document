using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Show
    {
        static void Main(string[] args)
        {
            Program pr = new People();
            pr.Input();
            if (pr is People)
            {
                ((People)pr).Eye();
            }
        }
    }
}
