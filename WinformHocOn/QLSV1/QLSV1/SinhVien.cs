using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    [Serializable]
    class SinhVien:IComparable<SinhVien>
    {
        public string masv { get; set; }
        public string tensv { get; set; }
        public int tuoi { get; set; }
        public string diachi { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string masv, string tensv, int tuoi, string diachi)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.tuoi = tuoi;
            this.diachi = diachi;
        }

        public override string ToString()
        {
            return "MSV : " + masv + " Tên SV : " + tensv + " Tuổi : " + tuoi + " Địa chỉ : " + diachi;
        }
        public override bool Equals(object obj)
        {
            SinhVien x = (SinhVien)obj;
            return x.masv.Equals(this.masv);
        }
        
        public int CompareTo(SinhVien sinhVien)
        {
            return this.tensv.CompareTo(sinhVien.tensv);
        }

    }
}
