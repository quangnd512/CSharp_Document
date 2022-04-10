using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class StudentMark
    {
        /**
         * Bài toán: Tạo lớp StudentMark có các thuộc tính: Rollnumber, Họ tên, Lớp, Môn học, Điểm,...
         * Cài đặt 2 contructor, Phương thức set, get,
         * Cài đặt hàm hiển thị, nhập,...
         * Khai báo luôn hàm main trong lớp này. 
         * KQ: In ra các thông tin mà người dùng nhập vào, hien thi nguoi co diem cao nhat
         *
         */
        private string rollno;
        private string name;
        private string className;
        private string subject;
        private float score;

        public StudentMark(){}
        public StudentMark(string rollno, string name, string className, string subject, float score)
        {
            this.rollno = rollno;
            this.name = name;
            this.className = className;
            this.subject = subject;
            this.score = score;
        }
        public string Rollno
        {
           get { return rollno; }
           set { rollno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public float Score
        {
            get { return score; }
            set { score = value; }
        }
        public void Input()
        {
            Console.WriteLine("Nhap thong tin sinh vien.! ");
            Console.Write("Nhap MSSV: ");
            Rollno = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap lop: ");
            ClassName = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap mon hoc: ");
            Subject = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap diem: ");
            Score = Convert.ToSingle(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"Thong tin: MSSV: {Rollno}, Ho va ten: {Name}, Lop: {ClassName}, Mon hoc: {Subject}, Diem: {Score}");
        }
        static void Main(string[] args)
        {
            StudentMark sm1 = new StudentMark();
            StudentMark sm2 = new StudentMark();
            sm1.Input();
            sm2.Input();
            if (sm1.Score>sm2.Score)
            {
                sm1.Show();
                sm2.Show();
            }else if (sm1.Score == sm2.Score)
            {
                sm1.Show();
                sm2.Show();
                Console.WriteLine("2 sinh vien bang diem nhau");
            }
            else
            {
                sm2.Show();
                sm1.Show();
            }
        }
    }
}
