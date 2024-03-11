using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAL
{
    public class AccInf
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";

        public void checkMK(string Ma, string mk,string mkNew)
        {
            int code;
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[checkMK] @ma='" + Ma + "',@MK='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                code = Convert.ToInt32(cmd.ExecuteScalar());
                if (code == 1)
                {
                   
                   this.uppdateMK(Ma, mkNew);
                   MessageBox.Show("Cập Nhật Thành Công", "Thông báo");
                }
                else if (code == 0)
                {
                    MessageBox.Show("Sai Mat Khau", "Thong Bao", MessageBoxButtons.OK);
                }
               
                con.Close();
            }
           
        }
         public void uppdateMK(string Ma, string mk)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open ();
                string sql = "exec [dbo].[updateMK] @ma='" + Ma + "',@mk='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close ();
            }
        }
    }
}
