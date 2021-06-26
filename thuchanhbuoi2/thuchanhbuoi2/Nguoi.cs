using System;
using System.Collections.Generic;
using System.Text;

namespace thuchanhbuoi2
{
    class Nguoi
    {
        public string ma{ get; set; }
        public string hoten { get; set; }

        public int tuoi { get; set; }
        public string diachi { get; set; }

        public Nguoi()
        {

        }
        public Nguoi(string ma,string hoten,int tuoi,string diachi)
        {
            this.ma = ma;
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.diachi = diachi;
        }
        public override string ToString()
        {
            return "Ma : " + ma +"\nTên : " + hoten +"\nTuổi : " +tuoi + "\nĐịa chỉ : "+diachi;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhập mã :");
            ma = Console.ReadLine();

            Console.WriteLine("Nhập họ và tên :");
            hoten = Console.ReadLine();

            Console.WriteLine("Nhập tuổi :");
            tuoi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập địa chỉ :");
            diachi = Console.ReadLine();
        }
    }
}
