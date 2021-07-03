using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1
{
    class Program
    {
        /**
         * Hãy xây dựng ứng dụng cho phép người dùng nhập vào ngày sinh và tháng sinh của
         * họ sau đó đưa ra kết luận người đó thuộc cung hoàng đạo nào. Ứng dụng cần kiểm
         * tra các ngoại lệ xảy ra như liệu ngày có hợp lệ không(không có ngày 31 của tháng 2
         * chẳng hạn), tháng sinh có hợp lệ không(không có tháng 13 chẳng hạn). Nếu người
         * dùng nhập sai, yêu cầu họ nhập lại hoặc thoát chương trình. 
         */
        static void LoopFalse()
        {
            while (true)
            {
                string str;
                Console.Write("Y de tiep tuc. N de thoat chuong trinh: ");
                str = Console.ReadLine();
                if (str == "Y" || str == "y")
                {
                    break;
                }
                else if (str == "N" || str == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            do
            {
                int date, month;
                while (true)
                {
                    Console.Write("Nhap ngay sinh: ");
                    date = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap thang sinh: ");
                    month = Convert.ToInt32(Console.ReadLine());

                    //Thang 2

                    if ((date > 0 && date <= 28 && month == 2) || (date > 0 && date <= 29 && month == 2))
                    {
                        break;
                    }

                    //30 ngay
                    if (date > 0 && date <= 30 && (month == 4 || month == 6 || month == 9 || month == 11))
                    {
                        break;
                    }

                    //30 ngay
                    if (date > 0 && date <= 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
                    {
                        break;
                    }
                    Console.WriteLine("Ban da nhap sai. Vui long chon: \n");
                    LoopFalse();
                }
                switch (month)
                {
                    case 1:
                        if (date<20)
                        {
                            Console.WriteLine("Ban thuoc cung ma ket.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung bao binh.!");
                        }
                        break;
                    case 2:
                        if (date < 19)
                        {
                            Console.WriteLine("Ban thuoc cung bao binh.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung song ngu.!");
                        }
                        break;
                    case 3:
                        if (date < 21)
                        {
                            Console.WriteLine("Ban thuoc cung song ngu.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung bach duong.!");
                        }
                        break;
                    case 4: if (date<20)
                        {
                            Console.WriteLine("Ban thuoc cung bach duong.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung kim nguu.!");
                        }
                        break;
                    case 5:
                        if (date < 21)
                        {
                            Console.WriteLine("Ban thuoc cung kim nguu.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung song tu.!");
                        }
                        break;
                    case 6:
                        if (date < 21)
                        {
                            Console.WriteLine("Ban thuoc cung song tu.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung cu giai.!");
                        }
                        break;
                    case 7:
                        if (date < 23)
                        {
                            Console.WriteLine("Ban thuoc cung cu giai.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung su tu.!");
                        }
                        break;
                    case 8:
                        if (date < 23)
                        {
                            Console.WriteLine("Ban thuoc cung su tu.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung xu nu.!");
                        }
                        break;
                    case 9:
                        if (date < 23)
                        {
                            Console.WriteLine("Ban thuoc cung xu nu.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung thien binh.!");
                        }
                        break;
                    case 10:
                        if (date < 23)
                        {
                            Console.WriteLine("Ban thuoc cung thien binh.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung bo cap.!");
                        }
                        break;
                    case 11:
                        if (date < 22)
                        {
                            Console.WriteLine("Ban thuoc cung bo cap.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung nhan ma.!");
                        }
                        break;
                    case 12:
                        if (date < 22)
                        {
                            Console.WriteLine("Ban thuoc cung nhan ma.!");
                        }
                        else
                        {
                            Console.WriteLine("Ban thuoc cung ma ket.!");
                        }
                        break;
                }
                Console.WriteLine();
                LoopFalse();
            } while (true);
        }
    }
}
