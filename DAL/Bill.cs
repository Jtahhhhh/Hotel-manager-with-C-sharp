using QKKS_ver_1._4_.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAL
{
    public class Bill
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";

        public string loadPrice(int pnp)
        {
            string price;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connect;
                conn.Open();
                string sql = "select DATEDIFF(DAY,TD_start,TD_end)*b.GP_gia from PhieuNhanPhong a, GiaPhong b, KhachNhanPhong c where a.PNP_id=c.PNP_id and b.LP_id=c.LP_id and KNP_trangThai=0 and a.PNP_id='" + pnp + "'";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(db);
                price = db.Tables[0].Rows[0][0].ToString();

                conn.Close();
            }
            return price;
        }
        public string loadTodayPrice(int pnp)
        {
            string price;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connect;
                conn.Open();
                string sql = "exec dbo.total @pnp='"+pnp+"'";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(db);
                price = db.Tables[0].Rows[0][0].ToString();

                conn.Close();
            }
            return price;
        }
        public string loadTotal(int pnp)
        {
            string total;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connect;
                conn.Open();
                string sql = "exec totalBill @pnp='" + pnp + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                total = cmd.ExecuteScalar().ToString();
                conn.Close();
            }

            return total;


        }

        public EMP getEMP(string NV_id)
        {
            EMP emp = null;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();

                string sql = "Select * from NhanVien where NV_id='" + NV_id + "'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(dt);
                emp = new EMP(dt.Rows[0]);

                con.Close();
            }
            return emp;

        }
        public Customer getCus(string KH_id)
        {
            Customer emp = null;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();

                string sql = "Select * from KhachHang where KH_id='" + KH_id + "'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(dt);
                emp = new Customer(dt.Rows[0]);

                con.Close();
            }
            return emp;

        }
        public void addService(string dv, string ldv, string pnp, string sl)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connect;
                conn.Open();
                string sql = "EXEC insertServiceToPNP @dv='" + dv + "',@ldv='" + ldv + "',@pnp='" + pnp + "',@sl='" + sl + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Them Thanh Cong");
                conn.Close();
            }
        }

        public void addServicePrice(int ma, string total)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[addServicePrice] @hd='" + ma + "',@tt='" + total + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void addTTTT(int ma, string total)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "exec  [dbo].[createTTTT] @hd='" + ma + "',@tt='" + total + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void checkOut(int ma,int tt)
        {
            using (SqlConnection con = new SqlConnection()) 
            { 
                con.ConnectionString = connect;
                con.Open();
                string sql = "exec dbo.checkOut @pnp='" + ma + "', @tt='" + tt + "'";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.ExecuteNonQuery();
                con.Close ();
            }
        }

    }
}