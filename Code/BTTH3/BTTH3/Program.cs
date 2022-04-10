using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH3
{
    class Program
    {
        /**
         * Tạo ứng dụng cho phép người dùng thực hiện rút tiền, kiểm tra tài khoản và nạp 
         * tiền vào tài khoản(giả lập). Số tiền cho phép rút bạn được tùy ý lựa chọn hoặc có 
         * các mức tùy chọn định sẵn như 200k, 500k. Máy chỉ cho rút khi bạn đã đăng nhập 
         * vào tài khoản ngân hàng của bạn. Số tiền cần rút là bội số của 10k và nhỏ hơn số
         * dư hiện tại trong tài khoản của bạn.
         */
        static void Main(string[] args)
        {
            string password = "123456";
            long balance = default; //So du
            bool login = false; //Login
            long amount = default; //So tien nap vao tk
            int choose = default; //Lua chon

            while (true)
            {
                Console.WriteLine("1. Dang nhap vao tai khoan");
                Console.WriteLine("2. Rut tien");
                Console.WriteLine("3. Nap tien");
                Console.WriteLine("4. Kiem tra so du");
                Console.WriteLine("5. Thoat chuong trinh");
                Console.Write("Xin moi chon: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        if (login)
                        {
                            Console.WriteLine("Ban da dang nhap thanh cong.!");
                        }
                        else
                        {
                            Console.Write("Moi ban nhap mat khau: ");
                            string isTrueLogin = Console.ReadLine();
                            if (isTrueLogin.CompareTo(password) == 0)
                            {
                                login = true;
                                Console.WriteLine("Ban da dang nhap thanh cong.!");
                            }
                            else
                            {
                                Console.WriteLine("Mat khau sai.");
                            }
                        }
                        break;
                    case 2:
                        if (login)
                        {
                            int choose1 = default;
                            Console.WriteLine("1. 50.000");
                            Console.WriteLine("2. 100.000");
                            Console.WriteLine("3. 200.000");
                            Console.WriteLine("4. 500.000");
                            Console.WriteLine("5. So tien khac.");
                            Console.Write("Xin moi chon: ");
                            choose1 = Convert.ToInt32(Console.ReadLine());
                            switch (choose1)
                            {
                                case 1:
                                    amount = 50000;
                                    if (balance>= amount)
                                    {
                                        balance -=amount;
                                        Console.WriteLine($"Ban da rut thanh cong {amount} VND.!");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }else if (n == "N" || n == "n")
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong du tien trong tai khoan. Hay nap them tien de thuc hien giao dich.");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            login = false;
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;
                                case 2:
                                    amount = 100000;
                                    if (balance >= amount)
                                    {
                                        balance -= amount;
                                        Console.WriteLine($"Ban da rut thanh cong {amount} VND.!");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong du tien trong tai khoan. Hay nap them tien de thuc hien giao dich.");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            login = false;
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;
                                case 3:
                                    amount = 200000;
                                    if (balance >= amount)
                                    {
                                        balance -= amount;
                                        Console.WriteLine($"Ban da rut thanh cong {amount} VND.!");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong du tien trong tai khoan. Hay nap them tien de thuc hien giao dich.");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            login = false;
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;
                                case 4:
                                    amount = 500000;
                                    if (balance >= amount)
                                    {
                                        balance -= amount;
                                        Console.WriteLine($"Ban da rut thanh cong {amount} VND.!");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong du tien trong tai khoan. Hay nap them tien de thuc hien giao dich.");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            login = false;
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    break;
                                case 5:
                                    Console.Write("Nhap so tien muon rut (Lon hon va la boi cua 10.000 VND): ");
                                    amount = Convert.ToInt64(Console.ReadLine());
                                    if (amount > 10000 && amount % 10000 == 0 && amount <= balance)
                                    {
                                        balance -= amount;
                                        Console.WriteLine($"Ban da rut thanh cong {amount} VND.!");
                                        Console.Write("Ban co muon thuc hien tiep giao dich.? Nhan Y de tiep tuc, N de thoat: ");
                                        string n = Console.ReadLine();
                                        if (n == "Y" || n == "y")
                                        {
                                            break;
                                        }
                                        else if (n == "N" || n == "n")
                                        {
                                            login = false;
                                        }
                                        else
                                        {
                                            Environment.Exit(0);
                                        }
                                    }
                                    else if(amount> balance)
                                    {
                                        Console.WriteLine("So du trong tai khoan khong du de rut.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{amount} khong phai lam boi cua 10.000 VND");   
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai lua chon.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ban phai nhap mat khau truoc.!");
                        }
                        break;
                    case 3:
                        if (login)
                        {
                            long isBalance = default;
                            Console.Write("Nhap so tien can nap: ");
                            isBalance = Convert.ToInt64(Console.ReadLine());
                            if(isBalance>10000)
                            {
                                Console.WriteLine($"Ban vua nap {isBalance} VND vao tai khoan.!");
                                balance += isBalance;
                            }
                            else
                            {
                                Console.WriteLine("Moi lan nap phai tren 10.000 VND");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ban phai nhap mat khau truoc.!");
                        }
                        break;
                    case 4:
                        if (login)
                        {
                            Console.WriteLine($"So du tai khoan cua ban la: {balance} VND");
                        }
                        else
                        {
                            Console.WriteLine("Ban phai nhap mat khau truoc.!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Cam on ban da su dung chuong trinh.!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sai chuc nang vui long nhap lai.!");
                        break;
                }
            }
        }
    }
}
