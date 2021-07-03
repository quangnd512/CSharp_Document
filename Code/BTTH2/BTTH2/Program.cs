using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    class Program
    {
        /**
          * Tạo menu tùy chọn cho phép người dùng thực hiện các phép tính toán cộng trừ
          * nhân chia, lấy dư, lũy thừa a^b từ hai số a, b nhập từ bàn phím. Khi thực hiện phép 
          * chia, lấy dư cần kiểm tra mẫu số phải đảm bảo khác 0 thì mới cho thực hiện, ngược 
          * lại yêu cầu người dùng nhập lại giá trị tử, mẫu hoặc thoát chức năng hoặc thoát 
          * khỏi chương trình.
        */
        static void YesNo()
        {
            while (true)
            {
                string c;
                Console.Write("Nhap Y de tiep tuc. N de ket thuc: ");
                c = Console.ReadLine();
                if (c == "Y" || c == "y")
                {
                    break;
                }
                else if (c == "N" || c == "n")
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
            int a, b;
            Console.Write("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                int n;
                Console.WriteLine("1. Phep cong ");
                Console.WriteLine("2. Phep tru ");
                Console.WriteLine("3. Phep nhan ");
                Console.WriteLine("4. Phep chia ");
                Console.WriteLine("5. Phep lay du ");
                Console.WriteLine("6. Phep luy thua ");
                Console.Write("Nhap phep tinh: ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: 
                        int sum;
                        sum = a + b;
                        Console.WriteLine($"Tong: {a} + {b} = {sum}");
                        YesNo();
                        int bol;
                        Console.WriteLine("1 Nhap lai so");
                        Console.WriteLine("2. Khong nhap lai so");
                        Console.Write("Ban co nhap lai so khong: ");
                        bol = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            if(bol == 1)
                            {
                                Console.Write("Nhap so a: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Nhap so b: ");
                                b = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        int sub;
                        int s;
                        Console.WriteLine("1. a - b ");
                        Console.WriteLine("2. b - a ");
                        while(true)
                        {
                            Console.Write("Chon phep tinh: ");
                            s = Convert.ToInt32(Console.ReadLine());
                            if (s == 1)
                            {
                                sub = a - b;
                                Console.WriteLine($"Hieu: {a} - {b} = {sub}");
                                YesNo();
                                int bol1;
                                Console.WriteLine("1 Nhap lai so");
                                Console.WriteLine("2. Khong nhap lai so");
                                Console.Write("Ban co nhap lai so khong: ");
                                bol1 = Convert.ToInt32(Console.ReadLine());
                                while (true)
                                {
                                    if (bol1 == 1)
                                    {
                                        Console.Write("Nhap so a: ");
                                        a = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Nhap so b: ");
                                        b = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            }
                            else if (s == 2)
                            {
                                sub = b - a;
                                Console.WriteLine($"Hieu: {b} - {a} = {sub}");
                                YesNo();
                                int bol2;
                                Console.WriteLine("1 Nhap lai so");
                                Console.WriteLine("2. Khong nhap lai so");
                                Console.Write("Ban co nhap lai so khong: ");
                                bol2 = Convert.ToInt32(Console.ReadLine());
                                while (true)
                                {
                                    if (bol2 == 1)
                                    {
                                        Console.Write("Nhap so a: ");
                                        a = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Nhap so b: ");
                                        b = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case 3:
                        int multi;
                        multi = a * b;
                        Console.WriteLine($"Tich: {a} * {b} = {multi}");
                        YesNo();
                        int bol3;
                        Console.WriteLine("1 Nhap lai so");
                        Console.WriteLine("2. Khong nhap lai so");
                        Console.Write("Ban co nhap lai so khong: ");
                        bol3 = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            if (bol3 == 1)
                            {
                                Console.Write("Nhap so a: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Nhap so b: ");
                                b = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 4:
                        if (a==0||b==0)
                        {
                            Console.Write("Nhap so a: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nhap so b: ");
                            b = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            float division;
                            int s4;
                            Console.WriteLine("1. a / b ");
                            Console.WriteLine("2. b / a ");
                            while (true)
                            {
                                Console.Write("Chon phep tinh: ");
                                s4 = Convert.ToInt32(Console.ReadLine());
                                if (s4 == 1)
                                {
                                    division = (float)a / b;
                                    Console.WriteLine($"Thuong: {a} / {b} = {division}");
                                    YesNo();
                                    int bol4;
                                    Console.WriteLine("1 Nhap lai so");
                                    Console.WriteLine("2. Khong nhap lai so");
                                    Console.Write("Ban co nhap lai so khong: ");
                                    bol4 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (bol4 == 1)
                                        {
                                            Console.Write("Nhap so a: ");
                                            a = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Nhap so b: ");
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    break;
                                }
                                else if (s4 == 2)
                                {
                                    division = (float)b / a;
                                    Console.WriteLine($"Thuong: {b} / {a} = {division}");
                                    YesNo();
                                    int bol2;
                                    Console.WriteLine("1 Nhap lai so");
                                    Console.WriteLine("2. Khong nhap lai so");
                                    Console.Write("Ban co nhap lai so khong: ");
                                    bol2 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (bol2 == 1)
                                        {
                                            Console.Write("Nhap so a: ");
                                            a = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Nhap so b: ");
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        break;
                    case 5:
                        if (a == 0 || b == 0)
                        {
                            Console.Write("Nhap so a: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nhap so b: ");
                            b = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            float division;
                            int s4;
                            Console.WriteLine("1. a % b ");
                            Console.WriteLine("2. b % a ");
                            while (true)
                            {
                                Console.Write("Chon phep tinh: ");
                                s4 = Convert.ToInt32(Console.ReadLine());
                                if (s4 == 1)
                                {
                                    division = (float)a % b;
                                    Console.WriteLine($"Thuong: {a} % {b} = {division}");
                                    YesNo();
                                    int bol4;
                                    Console.WriteLine("1 Nhap lai so");
                                    Console.WriteLine("2. Khong nhap lai so");
                                    Console.Write("Ban co nhap lai so khong: ");
                                    bol4 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (bol4 == 1)
                                        {
                                            Console.Write("Nhap so a: ");
                                            a = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Nhap so b: ");
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    break;
                                }
                                else if (s4 == 2)
                                {
                                    division = (float)b % a;
                                    Console.WriteLine($"Thuong: {b} % {a} = {division}");
                                    YesNo();
                                    int bol2;
                                    Console.WriteLine("1 Nhap lai so");
                                    Console.WriteLine("2. Khong nhap lai so");
                                    Console.Write("Ban co nhap lai so khong: ");
                                    bol2 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (bol2 == 1)
                                        {
                                            Console.Write("Nhap so a: ");
                                            a = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Nhap so b: ");
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        break;
                    case 6:
                        long pow;
                        int s1;
                        Console.WriteLine("1. a ^ b ");
                        Console.WriteLine("2. b ^ a ");
                        while (true)
                        {
                            Console.Write("Chon phep tinh: ");
                            s1 = Convert.ToInt32(Console.ReadLine());
                            if (s1 == 1)
                            {
                                pow = (long)Math.Pow(a, b);
                                Console.WriteLine($"Luy thua: {a} ^ {b} = {pow}");
                                YesNo();
                                int bol6;
                                Console.WriteLine("1 Nhap lai so");
                                Console.WriteLine("2. Khong nhap lai so");
                                Console.Write("Ban co nhap lai so khong: ");
                                bol6 = Convert.ToInt32(Console.ReadLine());
                                while (true)
                                {
                                    if (bol6 == 1)
                                    {
                                        Console.Write("Nhap so a: ");
                                        a = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Nhap so b: ");
                                        b = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            }
                            else if (s1 == 2)
                            {
                                pow = (long)Math.Pow(b, a);
                                Console.WriteLine($"Luy thua: {b} ^ {a} = {pow}");
                                YesNo();
                                int bol6;
                                Console.WriteLine("1 Nhap lai so");
                                Console.WriteLine("2. Khong nhap lai so");
                                Console.Write("Ban co nhap lai so khong: ");
                                bol6 = Convert.ToInt32(Console.ReadLine());
                                while (true)
                                {
                                    if (bol6 == 1)
                                    {
                                        Console.Write("Nhap so a: ");
                                        a = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Nhap so b: ");
                                        b = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    default: 
                        Console.WriteLine("Ban da nhap sai.! Vui long nhap lai.");
                        YesNo();
                        Console.WriteLine();
                        break;
                }
            } while (true);
        }
    }
}
