using System;

namespace Trinhdangnhap
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trinh dang nhap thong tin nguoi dung");
            Console.WriteLine("---------------*---*---------------");
            Class1.NguoiDung a = new Class1.NguoiDung();
            Console.WriteLine("Nhap ho ten cua nguoi dung: ");
            string temp = Console.ReadLine();
            string[] ten = temp.Split(" ");

        hoten:  //Nhap Ho va Ten
            for (int k = 0; k < ten.Length; k++)
            {
                for (int i = 0; i < ten[k].Length; i++)
                {

                    if (ten[k].Length > 0)
                    {
                        string temp1 = ten[k];
                        ten[k] = Convert.ToString(temp1[0]).ToUpper();
                        for (int j = 1; j < temp1.Length; j++)
                        {
                            ten[k] += Convert.ToString(temp1[j]).ToLower();
                        }
                    }
                }
            }

            for (int i = 0; i < ten.Length; i++)
            {
                a.HoTen += ten[i];
                if (i < ten.Length - 1 && ten[i] != "")
                {
                    a.HoTen += " ";
                }
            }


            Console.WriteLine("------------------------");
        username:   //Nhap Ten dang nhap
            Console.WriteLine("Ten Dang Nhap (khong co dau cach): ");
            a.TenDangNhap = Console.ReadLine();
            string clone_username = a.TenDangNhap;
            int n_username = clone_username.Length;
            {
                string b;
                for (int i = 0; i < n_username; i++)
                {
                    b = clone_username.Substring(0, 1);
                    clone_username = clone_username.Substring(1);
                    if (b == " ")
                    {
                        Console.WriteLine("Hay nhap lai, ten dang nhap sai dinh dang!");
                        Console.WriteLine("------------------------");
                        goto username;
                    }

                }
            }



            Console.WriteLine("------------------------");
        password:   //Nhap mat khau
            Console.WriteLine("Mat khau: ");
            a.Matkhau = Console.ReadLine();
            int n_password = a.Matkhau.Length;

            if (n_password < 8)
            {
                Console.WriteLine("Hay nhap lai, mat khau phai co it nhat 8 ky tu!");
                Console.WriteLine("------------------------");
                goto password;
            }

            string clone_password = a.Matkhau;
            string a1 = a.Matkhau;

            {

                string b;
                for (int i = 0; i < n_password; i++)
                {
                    b = clone_password.Substring(0, 1);
                    clone_password = clone_password.Substring(1);
                    if (b == " ")
                    {
                        Console.WriteLine("Hay nhap lai, mat khau khong duoc co dau cach!");
                        Console.WriteLine("------------------------");
                    }
                }

                int Uppercount = 0;
                int Lowercount = 0;
                int Digitcount = 0;
                for (int j = 0; j < n_password; j++)
                {
                    string a2 = a1.Substring(0, 1);
                    a1 = a1.Substring(1);
                    char c = char.Parse(a2);
                    if (Char.IsLetter(c))
                    {
                        if (Char.IsUpper(c))
                        {
                            Uppercount++;
                        }
                        else
                        {
                            Lowercount++;
                        }
                    }
                    else if (char.IsDigit(c))
                    {
                        Digitcount++;
                    }
                }
                if ((Uppercount == 0 || Lowercount == 0) || Digitcount == 0)
                {
                    Console.WriteLine("Mat khau phai co it nhat 1 chu cai thuong, 1 chu cai hoa và 1 chu so!");
                    Console.WriteLine("-----------------------");
                    goto password;
                }
            }
            
            
            Console.WriteLine("------------------------");
        Sdt:    //Nhap So Dien Thoai
            Console.WriteLine("So Dien Thoai");
            a.SoDienThoai = Console.ReadLine();
            int n0 = a.SoDienThoai.Length;
            string clone_number = a.SoDienThoai;
            char n1;
            if (n0<10 || n0 >11)
            {
                Console.WriteLine("Hay nhap lai, So dien thoai sai!");
                Console.WriteLine("------------------------");
                goto Sdt;
            }
            else
            {
                if (clone_number[0] !=)
                {
                    Console.WriteLine("Hay nhap lai, So dien thoai sai!");
                    Console.WriteLine("------------------------");
                }
                for (int i = 0; i < n0; i++)
                {
                    n1 = Convert.ToChar(clone_number.Substring(0, 1));
                    clone_number = clone_number.Substring(1);
                    if ((byte)n1 < 48 || (byte)n1 > 57)
                    {
                        Console.WriteLine("Hay nhap lai, So dien thoai sai!");
                        Console.WriteLine("------------------------");
                        goto Sdt;
                    }

                }
            }


            Console.WriteLine("------------------------");
        email:  //Nhap Email
            Console.WriteLine("Email: ");
            a.Email = Console.ReadLine();
            string clone_email = a.Email;
            string clone_email1 = a.Email;
            int n_email = clone_email.Length;
            {
                string c;
                int k = 0;
                for (int i = 0; i < n_email; i++)
                {
                    c = clone_email.Substring(0, 1);
                    clone_email = clone_email.Substring(1);
                    char d = char.Parse(c);
                    if ((byte)d == 64)
                    {
                        k = 1;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Hay nhap lai, email sai dinh dang! ( phai co dau @)");
                    Console.WriteLine("------------------------");
                    goto email;
                }

                if (clone_email1.LastIndexOf(".com") != a.Email.Length - 4)
                {
                    Console.WriteLine("Hay nhap lai, email sai dinh dang! ( phai co dau .com o cuoi)");
                    Console.WriteLine("------------------------");
                    goto email;
                }

            }


            Console.WriteLine("////----------------------------////");
            Console.WriteLine("Thong tin nguoi dung:");
            Console.WriteLine("Ho va ten nguoi dung: {0}",a.HoTen);
            Console.WriteLine("Ten dang nhap: {0}", a.TenDangNhap);
            Console.WriteLine("Mat khau: {0}",a.Matkhau);
            Console.WriteLine("So dien thoai: {0}",a.SoDienThoai);
            Console.WriteLine("Email: {0}", a.Email);


        }
    }
}
