using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class People : Program
    {
        protected string Name { get; set; }
        public People(string name)
        {
            this.Name = name;
        }
        public People()
        {

        }

        public void Eye()
        {
            Console.WriteLine("Eye");
        }

        public override void Input()
        {
            Console.WriteLine("Input");
        }
    }
}
