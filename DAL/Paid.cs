using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DAL
{
    public class Paid
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";

        public string Load(int ma)
        {
            string total;
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.ConnectionString = connect;    
                conn.Open();
                string sql = "Select TTTT_conLai from TinhTrangThanhToan where HD_id='"+ma+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                total = cmd.ExecuteScalar().ToString();
                conn.Close();
            }

            return total;
        }
        public void pay(int ma,string tien)
        {
            using (SqlConnection conn = new SqlConnection(connect)) 
            { 
                conn.ConnectionString = connect;
                conn.Open ();
                string sql ="Update TinhTrangThanhToan set TTTT_conLai -= "+tien+" Where HD_id="+ma+"";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close ();
            }
        }

    }
}
