using System;
using System.Collections.Generic;
using System.Text;

namespace baitap_3_2
{
    class Sinhvien:IComparable<Sinhvien>
    {
        public string sid { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public string address { get; set; }
        public Sinhvien()
        {
            sid = "Def_sid";
            name = "Def_name";
            phone = "Def_phone";
            address = "Def_address";
        }
        public override string ToString()
        {
            return sid + "," + name + "," + phone + "," + address;
        }
        public override bool Equals(object obj)
        {
            Sinhvien s2 = (Sinhvien)obj;
            return (s2.sid.Equals(this.sid));
        }
        public int CompareTo(Sinhvien other)
        {
            return (this.name.CompareTo(other.name));
        }
    }
}
