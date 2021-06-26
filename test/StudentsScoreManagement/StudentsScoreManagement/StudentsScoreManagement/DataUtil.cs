using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScoreManagement
{
    class DataUtil
    {
        SqlConnection con;
        public DataUtil()
        {
            string strconnect = @"Data Source=DESKTOP-O90RJHC;Initial Catalog=QLDiem;Integrated Security=True";
            con = new SqlConnection(strconnect);

        }


        // ------------------------- Bảng Điểm -----------------------

        public DataTable dsDiemSV()
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select * from DiemThi";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

        public DataTable dsSVMon(string mamh)
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select SinhVien.MaSV,HoDem,Ten,MaLop,MonHoc.MaMH,MonHoc.TenMH,KyHoc,SoTinChi,Diem from SinhVien inner join DiemThi on SinhVien.MaSV = DiemThi.MaSV inner join MonHoc on DiemThi.MaMH = MonHoc.MaMH where MonHoc.MaMH='" + mamh+"'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

        public Boolean NhapDiem(string maMH, string masv, int diem, int kyhoc)
        {
            con.Open();
            try
            {
                if (diem >= 0 && diem <= 10 && kyhoc >= 1 && kyhoc <= 8)
                {
                    SqlCommand sql = new SqlCommand("insert into DiemThi values (@mamh,@masv,@diem,@kyhoc)");
                    sql.Parameters.AddWithValue("@mamh", maMH);
                    sql.Parameters.AddWithValue("@masv", masv);
                    sql.Parameters.AddWithValue("@diem", diem);
                    sql.Parameters.AddWithValue("@kyhoc", kyhoc);
                    sql.Connection = con;
                    sql.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }
        public Boolean SuaDiem(int diemThi, string maMH, string masv)
        {
            con.Open();
            try
            {
                if (diemThi >= 0 && diemThi <= 10)
                {
                    SqlCommand sql = new SqlCommand("update DiemThi set Diem=@diemthi where MaMH=@mamh and MaSV=@masv");
                    sql.Parameters.AddWithValue("@diemthi", diemThi);
                    sql.Parameters.AddWithValue("@mamh", maMH);
                    sql.Parameters.AddWithValue("@masv", masv);
                    sql.Connection = con;
                    sql.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception)
            {

                con.Close();
                return false;
            }

        }

        public void DeleteDiem(string maMH, string masv)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("delete from DiemThi where MaMH=@mamh and MaSV=@masv");
            sql.Parameters.AddWithValue("@mamh", maMH);
            sql.Parameters.AddWithValue("@masv", masv);
            sql.Connection = con;
            sql.ExecuteNonQuery();
            con.Close();
        }

        public DataTable layDiemThi(string masv)
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select MonHoc.MaMH, TenMH, SoTinChi, HocKy, Diem from DiemThi inner join SinhVien on SinhVien.MaSV = DiemThi.MaSV"
                + " inner join MonHoc on DiemThi.MaMH = MonHoc.MaMH"
                + " where SinhVien.MaSV = '" + masv + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable timkiem(string msv, string mmh, string hk)
        {
            DataTable table = new DataTable();
            string sql = "";

            if (hk.Trim().Equals("") && !msv.Trim().Equals("") && !mmh.Trim().Equals(""))
            {
                sql = "select * from DiemThi where MaSV='" + msv + "'and MaMH='" + mmh + "'";
            }

            else if (msv.Trim().Equals("") && !hk.Trim().Equals("") && !mmh.Trim().Equals(""))
            {
                sql = "select * from DiemThi where MaMH='" + mmh + "' and KyHoc=" + hk + "";
            }

            else if (mmh.Trim().Equals("") && !hk.Trim().Equals("") && !msv.Trim().Equals(""))
            {
                sql = "select * from DiemThi where MaSV='" + msv + "'and KyHoc=" + hk + "";
            }

            else if (hk.Trim().Equals("") && msv.Trim().Equals("") && !mmh.Trim().Equals(""))
            {
                sql = "select * from DiemThi where MaMH='" + mmh + "'";
            }

            else if (mmh.Trim().Equals("") && hk.Trim().Equals("") && !msv.Trim().Equals(""))
            {
                sql = "select * from DiemThi where MaSV='" + msv + "'";
            }

            else if (msv.Trim().Equals("") && mmh.Trim().Equals("") && !hk.Trim().Equals(""))
            {
                sql = "select * from DiemThi where KyHoc=" + hk + "";
            }
            else if (!msv.Trim().Equals("") && !mmh.Trim().Equals("") && !hk.Trim().Equals(""))
            {
                sql = "select * from DiemThi where MaSV='" + msv + "'and MaMH='" + mmh + "' and KyHoc=" + hk + "";
            }
            else
            {
                sql = "select * from DiemThi ";
            }
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }







        //--------------------------------------------------






        public DataTable thongTinChiTiet(string masv)
        {
            DataTable table = new DataTable();
            string sql = "select * from SinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop"
                + " inner join DiemThi on SinhVien.MaSV = DiemThi.MaSV"
                + " inner join KhoaDaoTao on KhoaDaoTao.MaKhoa = Lop.MaKhoa"
                + " inner join MonHoc on DiemThi.MaMH = MonHoc.MaMH"
                + " where SinhVien.MaSV = '" + masv + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }



        // ------------------------- BẢNG MÔN HỌC  ----------------------

        public DataTable dsMonHoc()
        {
            DataTable table = new DataTable();
            string sql = "select * from MonHoc";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
       
        public DataTable timkiemMH(string mamh, string tenmh, string hk)
        {
            DataTable table = new DataTable();
            string sql = "";

            if (hk.Trim().Equals("") && !mamh.Trim().Equals("") && !tenmh.Trim().Equals(""))
            {
                sql = "select * from MonHoc where MaMH='" + mamh + "'and TenMH=N'" + tenmh + "'";
            }

            else if (mamh.Trim().Equals("") && !hk.Trim().Equals("") && !tenmh.Trim().Equals(""))
            {
                sql = "select * from MonHoc where TenMH=N'" + tenmh + "' and HocKy=" + hk + "";
            }

            else if (tenmh.Trim().Equals("") && !hk.Trim().Equals("") && !mamh.Trim().Equals(""))
            {
                sql = "select * from MonHoc where MaMH='" + mamh + "'and HocKy=" + hk + "";
            }

            else if (hk.Trim().Equals("") && mamh.Trim().Equals("") && !tenmh.Trim().Equals(""))
            {
                sql = "select * from MonHoc where TenMH=N'" + tenmh + "'";
            }

            else if (tenmh.Trim().Equals("") && hk.Trim().Equals("") && !mamh.Trim().Equals(""))
            {
                sql = "select * from MonHoc where MaMH='" + mamh + "'";
            }

            else if (mamh.Trim().Equals("") && tenmh.Trim().Equals("") && !hk.Trim().Equals(""))
            {
                sql = "select * from MonHoc where HocKy='" + hk + "'";
            }
            else if (!mamh.Trim().Equals("") && !tenmh.Trim().Equals("") && !hk.Trim().Equals(""))
            {
                sql = "select * from MonHoc where MaMH='" + mamh + "'and TenMH=N'" + tenmh + "' and HocKy=" + hk + "'";
            }
            else
            {
                sql = "select * from MonHoc";
            }
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
   
        public Boolean XoaMH(string maMH)
        {
            try
            {
                con.Open();
                SqlCommand sql = new SqlCommand("delete from MonHoc where MaMH=@mamh");
                sql.Parameters.AddWithValue("@mamh", maMH);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }
        public void SuaMH(MonHoc mh)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("update MonHoc set TenMH=@tenMH,SoTinChi=@sotc,HocKy=@hocky where MaMH=@mamh");
            sql.Parameters.AddWithValue("@tenMH", mh.Tenmh);
            sql.Parameters.AddWithValue("@sotc", mh.Sotinchi);
            sql.Parameters.AddWithValue("@hocky", mh.Hocky);
            sql.Parameters.AddWithValue("@mamh", mh.Mamh);
            sql.Connection = con;
            sql.ExecuteNonQuery();
            con.Close();
        }

        public Boolean nhapMH(MonHoc monHoc)
        {
            con.Open();
            try
            {

                SqlCommand sql = new SqlCommand("insert into MonHoc values (@mamh,@tenmh,@sotinchi,@hocky)");
                sql.Parameters.AddWithValue("@mamh", monHoc.Mamh);
                sql.Parameters.AddWithValue("@tenmh", monHoc.Tenmh);
                sql.Parameters.AddWithValue("@sotinchi", monHoc.Sotinchi);
                sql.Parameters.AddWithValue("@hocky", monHoc.Hocky);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }

        }



        // -------------------------------- BẢNG SINH VIÊN -----------------------

        public DataTable dsSV()
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select * from SinhVien";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }




        // -------------------------------- BẢNG KHOA -----------------------
        public DataTable dsKhoa()
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select * from KhoaDaoTao";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public Boolean xoaKhoa(string maKhoa)
        {
            try
            {

                con.Open();
                SqlCommand sql = new SqlCommand("delete from KhoaDaoTao where MaKhoa=@maKhoa");
                sql.Parameters.AddWithValue("@maKhoa", maKhoa);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }

        public DataTable timkiemKhoa(string maKhoa, string tenKhoa, string DienThoai)
        {
            DataTable table = new DataTable();
            string sql = "select * from KhoaDaoTao";

            if(!maKhoa.Equals(""))
            {
                sql = sql + " where MaKhoa='" + maKhoa + "'";
                if(!tenKhoa.Equals(""))
                {
                    sql = sql + " and TenKhoa=N'" + tenKhoa + "'";
                    if(!DienThoai.Equals(""))
                    {
                        sql = sql + " and DienThoai='" + DienThoai + "'";
                    }    
                }
            }
            else
            {
                if (!tenKhoa.Equals(""))
                {
                    sql = sql + " where TenKhoa=N'" + tenKhoa + "'";
                    if (!DienThoai.Equals(""))
                    {
                        sql = sql + " and DienThoai='" + DienThoai + "'";
                    }
                }
                else
                {
                    if (!DienThoai.Equals(""))
                    {
                        sql = sql + " where DienThoai='" + DienThoai + "'";
                    }
                }    
            }    
            
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

        public Boolean SuaKhoa(string makhoa,string tenkhoa,string dienthoai)
        {
            con.Open();
            try
            {
                SqlCommand sql = new SqlCommand("update KhoaDaoTao set TenKhoa=@tenKhoa,DienThoai=@dienthoai where MaKhoa=@maKhoa");
                sql.Parameters.AddWithValue("@tenKhoa", makhoa);
                sql.Parameters.AddWithValue("@dienthoai", dienthoai);
                sql.Parameters.AddWithValue("@maKhoa", makhoa);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }

        }
        public Boolean NhapKhoa(string makhoa, string tenkhoa, string dienthoai)
        {
            con.Open();
            try
            {

                SqlCommand sql = new SqlCommand("insert into KhoaDaoTao values (@maKhoa,@tenKhoa,@dienThoai)");
                sql.Parameters.AddWithValue("@maKhoa", makhoa);
                sql.Parameters.AddWithValue("@tenKhoa", dienthoai);
                sql.Parameters.AddWithValue("@dienThoai", makhoa);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }

        }


        // --------------------------- BẢNG LỚP--------------------------

        public DataTable dsLop()
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select * from Lop";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public Boolean xoaLop(string maLop)
        {
            try
            {

                con.Open();
                SqlCommand sql = new SqlCommand("delete from Lop where MaLop=@malop");
                sql.Parameters.AddWithValue("@malop", maLop);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }

        public Boolean SuaLop(Lop lop)
        {
            con.Open();
            try
            {
                SqlCommand sql = new SqlCommand("update Lop set MaKhoa=@makhoa,TenLop=@tenLop,Khoa=@khoa,HeDaoTao=@hedt,NamNhapHoc=@namnh,SiSo=@siso where MaLop=@malop");
                sql.Parameters.AddWithValue("@makhoa", lop.maKhoa);
                sql.Parameters.AddWithValue("@tenLop", lop.tenLop);
                sql.Parameters.AddWithValue("@khoa", lop.khoa);
                sql.Parameters.AddWithValue("@hedt", lop.heDaoTao);
                sql.Parameters.AddWithValue("@namnh", lop.nam);
                sql.Parameters.AddWithValue("@siso", lop.siso);
                sql.Parameters.AddWithValue("@malop", lop.maLop);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
           
        }

        public Boolean NhapLop(Lop lop)
        {
            con.Open();
            try
            {

                SqlCommand sql = new SqlCommand("insert into Lop values (@malop,@makhoa,@tenLop,@khoa,@hedt,@namnh,@siso)");
                sql.Parameters.AddWithValue("@malop", lop.maLop);
                sql.Parameters.AddWithValue("@makhoa", lop.maKhoa);
                sql.Parameters.AddWithValue("@tenLop", lop.tenLop);
                sql.Parameters.AddWithValue("@khoa", lop.khoa);
                sql.Parameters.AddWithValue("@hedt", lop.heDaoTao);
                sql.Parameters.AddWithValue("@namnh", lop.nam);
                sql.Parameters.AddWithValue("@siso", lop.siso);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }

        }

        public DataTable timkiemLop(string malop, string makhoa, string tenlop,string khoa,string hedt,string nam)
        {
            DataTable table = new DataTable();
            string sql = "select * from Lop";
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            if (!malop.Equals(""))
            {
                a.Add(malop);
                b.Add("MaLop");
            }
            if (!makhoa.Equals(""))
            {
                a.Add(makhoa);
                b.Add("MaKhoa");
            }
            if (!tenlop.Equals(""))
            {
                b.Add("TenLop"); 
                a.Add(tenlop);
            }
            if (!khoa.Equals(""))
            {
                a.Add(khoa);
                b.Add("Khoa");
            }
            if (!hedt.Equals(""))
            {
                a.Add(hedt);
                b.Add("HeDaoTao");
            }
            if (!nam.Equals(""))
            {
                a.Add(nam);
                b.Add("NamNhapHoc");
            }
            if(!(a.Count == 0))
            {
                sql = sql + " where";
                for (int i = 0; i < a.Count; i++)
                {
                    if(i == 0)
                        sql +=" "+ b[i] + "=N'" + a[i] + "'";
                    else 
                        sql += " and " + b[i] + "=N'" + a[i] + "'";

                }
            }
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }


        public DataTable dsTK()
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select * from DangNhap";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public Boolean ThemTaiKhoan(string userID, string ten, string passWord)
        {
            con.Open();
            try
            {
                SqlCommand sql = new SqlCommand("insert into DangNhap values (@UserID,@Ten,@Password)");
                sql.Parameters.AddWithValue("@UserID", userID);
                sql.Parameters.AddWithValue("@Ten", ten);
                sql.Parameters.AddWithValue("@Password", passWord);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }

        }
        public Boolean SuaTaiKhoan(string Ten, string passWord)
        {
            con.Open();
            try
            {
                SqlCommand sql = new SqlCommand("update DangNhap set Password=@passWord where Ten=@ten");
                sql.Parameters.AddWithValue("@passWord", passWord);
                sql.Parameters.AddWithValue("@ten", Ten);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }

        }
        public Boolean XoaTaiKhoan(string ten)
        {
            try
            {

                con.Open();
                SqlCommand sql = new SqlCommand("delete from DangNhap where Ten=@ten");
                sql.Parameters.AddWithValue("@ten", ten);
                sql.Connection = con;
                sql.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }
    }
}
