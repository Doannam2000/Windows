using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySVConsole
{
    [Serializable]
    class SinhVien : IComparable<SinhVien>
    {
        public string ID { get; set; }
        public string tenSV { get; set; }
        public int tuoi { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string ID, string tenSV, int tuoi)
        {
            this.ID = ID;
            this.tenSV = tenSV;
            this.tuoi = tuoi;
        }
        public override string ToString()
        {
            return ID + " , " + tenSV + " , " + tuoi;
        }

        public override bool Equals(object obj)
        {
            SinhVien x = (SinhVien)obj;
            return this.ID.Equals(x.ID);
        }
        public int CompareTo(SinhVien sinhVien)
        {
            return (this.ID.CompareTo(sinhVien.ID));
        }
        public SinhVien(String ID)
        {
            this.ID = ID;
        }
    }
}
