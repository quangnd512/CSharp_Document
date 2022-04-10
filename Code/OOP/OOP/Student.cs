using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student
    {
        public string emtyID;
        public string password;


        public Student()
        {

        }
        public Student(string email = "quang@gmail.com")
        {
            Email = email;
        }

        public string Email { get; set; } = "ABC@gmail.com";

        public string EmtyID
        {
            get => emtyID;
        }

        public string CkeckPass
        {
            set
            {
                password = value;
            }
        }


    }
}
