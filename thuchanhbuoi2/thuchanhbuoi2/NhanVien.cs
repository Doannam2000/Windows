using System;
using System.Collections.Generic;
using System.Text;

namespace thuchanhbuoi2
{
    class NhanVien:Nguoi
    {
        public int  luong{ get; set; }
        public int tienthuong { get; set; }

        public NhanVien()
        {
                
        }
        public NhanVien(string m,string ten,int tuoi,string diachi,int luong):base(m,ten,tuoi,diachi)
        {
            this.luong = luong;
        }
        public override string ToString()
        {
            thuong();
            return base.ToString() + "\nLương : " + luong + "\nThưởng : " + tienthuong;
        }
        public void thuong()
        {
            if (luong > 1000000)
            {
                tienthuong = luong * 10 / 100;
            }
            else
                tienthuong = 0;
        }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập lương :");
            luong = Convert.ToInt32(Console.ReadLine());
        }
    }
}
