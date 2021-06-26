using System;
using System.Collections.Generic;
using System.Text;

namespace baitap_3_2
{
    class SinhvienModel
    {
        static List<Sinhvien> li = new List<Sinhvien>();

        static void AddSinhvien(Sinhvien s)
        {
            li.Add(s);
        }
        static void Display()
        {
            foreach(Sinhvien s in li)
            {
                Console.WriteLine(s);
            }
        }
        static int FindBySid(string sid)
        {
            Sinhvien s = new Sinhvien();
            s.sid = sid;
            return li.IndexOf(s);
        }
        static void DelSinhvien(string sid)
        {
            try
            {
                Sinhvien s = new Sinhvien();
                s.sid = sid;
                li.Remove(s);

            }
            catch(Exception)
            {
                Console.WriteLine("Không có sinh vien này");
            }
        }
        static void InsertSinhvien(int vt, Sinhvien s)
        {
            li.Insert(vt, s);
        }
        static void SortSinhvien()
        {
            li.Sort();
            Display();
        }
    }
}
