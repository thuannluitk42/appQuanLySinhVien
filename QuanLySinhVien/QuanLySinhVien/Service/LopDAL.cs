using QuanLySinhVien.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Service
{
    class LopDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public LopDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllClass()
        {
            // tao cau lenh SQL
            string sql = "Select * from Lop";
            // khoi tao ket noi
            SqlConnection con = dc.getConnection();
            // Khoi tao doi tuong lop SqlDataAdapter
            con.Open();
            // do du lieu tu SqlDataAdapter -> datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            // dong ket noi
            con.Close();
            return dt;

        }

        public bool InsertClass(Lop lop)
        {
            string sql = "INSERT INTO dbo.Lop VALUES(@MaLop, @TenLop)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
            }
            catch (Exception e)
            {

            }
        }
            
    }
}
