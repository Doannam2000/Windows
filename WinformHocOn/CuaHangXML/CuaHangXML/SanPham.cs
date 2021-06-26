using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangXML
{

    class SanPham
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string hangsx{ get; set; }
        public int sl { get; set; }
        public int giatien { get; set; }

        public SanPham()
        {

        }
        public SanPham(string masp,string tensp,string hangsx,int sl,int dongia)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.hangsx = hangsx;
            this.sl = sl;
            this.giatien = dongia;
        }

/*        public override bool Equals(object obj)
        {
            SanPham x = (SanPham)obj;
            return x.masp.Equals(this.masp);
        }*/
    }
}
