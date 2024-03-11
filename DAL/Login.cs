using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
using QKKS_ver_1._4_.DTO;

namespace QKKS_ver_1._4_.DAL
{
    public class Login
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        public int checkLogin(string tk, string mk) 
        {
            int code;
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[checkLogin] @tk='"+tk+"',@mk='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,con);
                code = Convert.ToInt32(cmd.ExecuteScalar());
                if (code == 0)
                {
                    MessageBox.Show("Dang nhap thanh cong", "Thong Bao", MessageBoxButtons.OK);
                }
                else if (code == 1)
                {
                    MessageBox.Show("Sai Mat Khau", "Thong Bao", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tai Khoang Khong Ton Tai", "Thong Bao", MessageBoxButtons.OK);
                }
                con.Close();
            }
            return code;
        }

        public int checkLogin(DTO.EMP emp
            )
        {
            int code;
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[checkLogin] @tk='" + emp.TaiKhoan + "',@mk='" + emp.MatKhau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                code = Convert.ToInt32(cmd.ExecuteScalar());
                if (code == 0)
                {
                    MessageBox.Show("Dang nhap thanh cong", "Thong Bao", MessageBoxButtons.OK);
                }
                else if (code == 1)
                {
                    MessageBox.Show("Sai Mat Khau", "Thong Bao", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tai Khoang Khong Ton Tai", "Thong Bao", MessageBoxButtons.OK);
                }
                con.Close();
            }
            return code;
        }
        public EMP getEMP(string tk)
        {
            EMP emp = null;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();

                string sql = "exec [dbo].[getEMP] @tk='" + tk + "'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(dt);
                emp = new EMP(dt.Rows[0]);

                con.Close();
            }
            return emp;

        }
    }
}
