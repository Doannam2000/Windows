using System;
using System.Collections.Generic;
using System.Text;

namespace thuchanhbuoi2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            List<NhanVien> nv = new List<NhanVien>();
            int n;
            Console.WriteLine("Nhập số lượng nhân viên :");
            n = Convert.ToInt32(Console.ReadLine());
           for(int i = 0;i<n;i++)
           {
                Console.WriteLine("Nhập nhân viên {0} :", i + 1);
                NhanVien nv1 = new NhanVien();
                nv1.Nhap();
                nv.Add(nv1);
           }
            foreach (NhanVien item in nv)
            {
                Console.WriteLine(item);
            }
        }
    }
}
