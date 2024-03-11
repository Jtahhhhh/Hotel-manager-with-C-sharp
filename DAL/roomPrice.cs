using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAL
{
    public class roomPrice
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        //add dùng tham số
        public void addRoomPrice(DateTime daystart1, DateTime dayend1, int money1, DateTime daystart2, DateTime dayend2, int money2, DateTime daystart3, DateTime dayend3, int money3)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = connect;
                con.Open();
                string sql = " EXEC[dbo].[UpdateGia] @giaDeluxe = '"+money1+"',@startDeluxe = '"+daystart1+"',@endDeluxe = '"+dayend1+"',@giaSuperior = '"+money2+"',@startSuperior = '"+daystart2+"',@endSuperior = '"+dayend2+"',@giaFamily = '"+money3+"',@startFamily = '"+daystart3+"',@endFamily = '"+dayend3+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã Cập Nhật Thành Công", "Thông Báo");
                con.Close();
            }
        }
    }
}


