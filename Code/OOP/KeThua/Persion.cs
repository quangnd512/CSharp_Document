using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Persion : Program
    {
        protected int age;

        public override void Input()
        {
            Console.WriteLine("Input");
        }

        public Persion(int age)
        {
            this.age = age;
        }
        public Persion()
        {

        }

        public void Hand()
        {
            Console.WriteLine("Hand");
        }
    }
}
