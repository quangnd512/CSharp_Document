using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Persion
    {
        private string name;
        private int age;

        public string Name 
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public Persion (string Name, int  Age)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"Name: {name} | Age: {age}"; 
        }
    }
}
