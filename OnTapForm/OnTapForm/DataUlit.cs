using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapForm
{
    class DataUlit
    {
        SqlConnection con;
        public DataUlit()
        {
            string str = @"Data Source=DESKTOP-O90RJHC;Initial Catalog=ktpm1;Integrated Security=True";
            con = new SqlConnection(str);
        }

        public DataTable dsCompany()
        {
            con.Open();
            DataTable table = new DataTable();
            string sql = "select * from tblCompany";
            SqlDataAdapter data = new SqlDataAdapter(sql, con);
            data.Fill(table);
            con.Close();
            return table;
        }

        public bool add(Company cp)
        {
            con.Open();
            string sql = "insert into tblCompany values(@name,@phone,@salary,@addrid)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", cp.name);
            cmd.Parameters.AddWithValue("@phone", cp.phone);
            cmd.Parameters.AddWithValue("@salary", cp.salary);
            cmd.Parameters.AddWithValue("@addrid", cp.addrid);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool del(string id)
        {
            con.Open();
            string sql = "delete tblCompany where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            if(cmd.ExecuteNonQuery()<0)
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }
    }

}
