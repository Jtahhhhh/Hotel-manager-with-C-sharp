using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QKKS_ver_1._4_.DTO;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAL
{
    public class Room
    {
        //Chuỗi nối kết
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        //add dùng tham số
        public void addRoom(string LP,DateTime daystart,DateTime dayend,string money,int soPhong,int soTang,string ghiChu,string tinhTrang)
        {
            using (SqlConnection con = new SqlConnection())
            {
             
                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[InsertPhong] @LP_id='"+LP+"',@TDstart ='"+daystart+"', @TDend = '"+dayend+"',@money='"+money+"',@P_soPhong='"+soPhong+"',@T_soTang='"+soTang+"',@P_ghiChu=N'"+ghiChu+"',@P_tinhTrang=N'"+tinhTrang+"' ";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //add dùng đối tượng
        public void addRoom(DTO.Room room, DTO.RoomPrice rp)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[InsertPhong] @LP_id='" + room.LoaiPhong + "',@TDstart ='" + rp.Start + "', @TDend = '" + rp.End + "',@money='" + rp.Money + "',@P_soPhong='" + room.SoPhong + "',@T_soTang='" + Convert.ToInt32(room.SoTang) + "',@P_ghiChu=N'" + room.GhiChu + "',@P_tinhTrang=N'" + room.TinhTrang + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Update dùng tham số
        public void updateRoom(string LP, DateTime daystart, DateTime dayend, string money, int soPhong, int soTang, string ghiChu, string tinhTrang)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[updatePhongPlus] @LP_id1='" + LP + "',@start ='" + daystart + "', @end = '" + dayend + "',@price='" + money + "',@soPhong='" + soPhong + "',@soTang='" + soTang + "',@ghiChu=N'" + ghiChu + "',@tinhTrang=N'" + tinhTrang + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Update dùng đối tượng
        public void updateRoom(DTO.Room room,DTO.RoomPrice rp,string tinhTrang)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[updatePhongPlus] @LP_id1='" + room.LoaiPhong + "',@start ='" + rp.Start + "', @end = '" + rp.End + "',@price='" + rp.Money + "',@soPhong='" + room.SoPhong + "',@soTang='" +room.SoTang + "',@ghiChu=N'" + room.GhiChu + "',@tinhTrang=N'" + tinhTrang + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Delete dùng tham số
        public void deleteroom(string LP, DateTime daystart, DateTime dayend,int soPhong, int soTang)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connect;
                conn.Open();
                string sql = "exec [dbo].[deletePhong] @lp_id='" + LP + "', @soTang = '" + soTang + "', @soPhong ='" + soPhong + "',@start ='" + daystart + "',@end='" + dayend + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        //Delete dùng đối tượgn
        public void deleteroom(DTO.Room room, DTO.RoomPrice rp)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connect;
                conn.Open();
                string sql = "exec [dbo].[deletePhong] @lp_id='" + room.LoaiPhong + "', @soTang = '" + room.SoTang + "', @soPhong ='" + room.SoPhong + "',@start ='" + rp.Start + "',@end='" + rp.End + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
        public DTO.RoomPrice getPrice(string LP)
        {
            DTO.RoomPrice r = null;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();

                string sql = "Select * from GiaPhong where LP_id='"+LP+"'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(dt);
                r = new RoomPrice(dt.Rows[0]);

                con.Close();
            }
            return r;

        }
        public void updateRoom(DTO.Room room)
        {
            using(SqlConnection con = new SqlConnection()) 
            { 
                con.ConnectionString=connect;
                con.Open();
                string sql = "Update Phong set P_tinhTrang=N'Trống' where P_soPhong='"+room.SoPhong+"' and T_soTang='"+room.SoTang+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
               
                con.Close();
            }
        }
    }
}
