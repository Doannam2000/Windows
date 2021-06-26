using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKTra2
{
    [Serializable]
    class Student
    {
        public int maSV{ get; set; }
        public string tenSV{ get; set; }
        public string diaChi { get; set; }
        public string queQuan { get; set; }

        public Student()
        {

        }
        public Student(int maSV, string tenSV, string diaChi, string queQuen)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diaChi = diaChi;
            this.queQuan = queQuan;
        }
        public override bool Equals(object obj)
        {
            return this.maSV.Equals(((Student)obj).maSV);
        }
    }
}
