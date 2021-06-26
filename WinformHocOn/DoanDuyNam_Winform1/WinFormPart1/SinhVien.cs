using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPart1
{
    [Serializable]
    class SinhVien
    {
        public string masv { get; set; }

        public string hoten { get; set; }
        public int tuoi { get; set; }
        public  string diachi { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(string masv)
        {
            this.masv = masv;
        }

        public override bool Equals(object obj)
        {
            SinhVien x = (SinhVien)obj;
            return x.masv.Equals(this.masv);
        }
    }
}
