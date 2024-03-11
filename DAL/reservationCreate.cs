using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QKKS_ver_1._4_.DTO;

namespace QKKS_ver_1._4_.DAL
{
    public class reservationCreate
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";

        public int loadServiceId()
        {
            int id;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select  count(PDP_id) From PhieuDatPhong";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(db);
                id = Convert.ToInt32(db.Tables[0].Rows[0][0]);
                id++;
                con.Close();
            }
            return id;
           
        }
        public string loadCustomerId()
        {
            int id;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select  count(KH_id) From KhachHang";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(db);
                id = Convert.ToInt32(db.Tables[0].Rows[0][0]);
                id++;
                con.Close();
            }
            if (id >= 10) return "KH" + id;
            else return "KH0" + id;

        }
        public void addReservation(string ten,string sdt,string manv,int ma,string note,DateTime start,DateTime end,string LP)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql1 = "exec [dbo].[checkKH] @ten="+ten+",@sdt='"+sdt+"'";
                SqlCommand sqlCommand1 = new SqlCommand(sql1, con);
                string test = sqlCommand1.ExecuteScalar().ToString();
                if ( test != "0")
                {
                    string sql2 = "exec [dbo].[CreatePDP] @makh='" + test + "',@ten='" + ten + "',@sdt='" + sdt + "',@ma='" + this.loadServiceId() + "',@note='" + note + "' ,@manv='" + manv + "',@start='" + start + "',@end='" + end + "',@ngayLap='" + DateTime.Today + "',@LP='" + LP + "'";
                    SqlCommand sqlCommand = new SqlCommand(sql2, con);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    string sql2 = "exec [dbo].[CreatePDP] @makh='" + this.loadCustomerId() + "',@ten='" + ten + "',@sdt='" + sdt + "',@ma='" + this.loadServiceId() + "',@note='" + note + "' ,@manv='" + manv + "',@start='" + start + "',@end='" + end + "',@ngayLap='" + DateTime.Today + "',@LP='" + LP + "'";
                    SqlCommand sqlCommand = new SqlCommand(sql2, con);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                
                con.Close();
            }
        }
       
    }
}
