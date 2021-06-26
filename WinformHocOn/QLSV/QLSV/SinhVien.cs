using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV
{
    [Serializable]
    class SinhVien
    {
        public string masv { get; set; }
        public string tensv { get; set; }
        public int tuoi { get; set; }
        public string diachi { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string masv,string tensv,int tuoi,string diachi)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.tuoi = tuoi;
            this.diachi = diachi;
        }

        public override string ToString()
        {
            return "MSV : "+masv+" Tên SV : "+tensv+" Tuổi : "+tuoi+" Địa chỉ : "+diachi;
        }
        public override bool Equals(object obj)
        {
            SinhVien x = (SinhVien)obj;
            return x.masv.Equals(this.masv);
        }
        public int CompareTo(SinhVien sv,int x)
        {
            switch(x)
            {
                case 1:
                    return sv.masv.CompareTo(this.masv);
                case 2:
                    return sv.tensv.CompareTo(this.tensv);
                case 3:
                    return sv.tuoi.CompareTo(this.tuoi);
                case 4:
                    return sv.diachi.CompareTo(this.diachi);
            }
            return 0;
        }
        
    }
}
