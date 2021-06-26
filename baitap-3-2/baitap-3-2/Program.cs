using System;

namespace baitap_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luachon = 0;
            do
            {
                Console.WriteLine("\n ***** DS SINH VIEN ******");
                Console.WriteLine("1. Nhap 1 sinh vien ");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Tim sinh vien theo sid");
                Console.WriteLine("4. Xoa sinh vien theo sid");
                Console.WriteLine("5. Chen sinh vien vao vi tri bat ki");
                Console.WriteLine("6. Sap xep danh sach sinh vien va hien thi");
                Console.WriteLine("7. Ke thuc");
                Console.Write("*** Ban Chon : ");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Sinhvien s = new Sinhvien();
                        Console.Write("Nhap sid:");
                        s.sid = Console.ReadLine();
                        Console.Write("Nhap name:");
                        s.name = Console.ReadLine();
                        Console.Write("Nhap phone:");
                        s.phone = Console.ReadLine();
                        Console.Write("Nhap address:");
                        s.address = Console.ReadLine();
                        Addsinhvien(s);
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Console.Write("Nhap sid can tim:");
                        string sid = Console.ReadLine();
                        int kq = FindBySid(sid);
                        if (kq == -1)
                            Console.WriteLine("Khong Co");
                        else
                        {
                            Console.WriteLine("Tim Thay o vi tri :" + kq);
                            Console.WriteLine("Chi tiet sinh vien :" + li[kq]);
                        }
                    case 6:
                        SortSinhvien();
                        break;
                }
            } while (luachon != 7);
        }
    }
}
