using System;
using QKKS_ver_1._4_.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Data;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAL
{
    public class Service
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        //ADD dùng tham số
        public void AddService(string dv_id,string LDV_id,string dv_ten,string money,DateTime start,DateTime end )
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "EXEC [dbo].[checkService] @ldv_id='" + LDV_id + "',@dv_id='" + dv_id + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int code = Convert.ToInt32(cmd.ExecuteScalar());
                if (code == 1) MessageBox.Show("Dịch vụ đã tồn tại", "Thông báo");
                else
                {
                    sql = "EXEC [dbo].[USP_InsertServiceListPlus] @dv_id1 = '" + dv_id + "',@dv_ten1 = N'" + dv_ten + "', @ldv_id1 = '" + LDV_id + "',@GDV_gia1 = '" + money + "',@start1 = '" + start + "', @end1 = '" + end + "' ";
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }    
                con.Close();
            }

        }
        //ADD dùng object
        public void AddService(DTO.Service service,DTO.ServicePrice sp)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "EXEC [dbo].[checkService] @ldv_id='" + service.LoaiDichVu + "',@dv_id='" + service.DichVu + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int code = Convert.ToInt32(cmd.ExecuteScalar());
                if (code == 1) MessageBox.Show("Dịch vụ đã tồn tại", "Thông báo");
                else 
                {
                    sql = "EXEC [dbo].[USP_InsertServiceListPlus] @dv_id1 = '" + service.DichVu + "',@dv_ten1 = N'" + service.Ten + "', @ldv_id1 = '" + service.LoaiDichVu + "',@GDV_gia1 = '" + sp.Money + "',@start1 = '" + sp.Start + "', @end1 = '" + sp.End + "' ";
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
               
                con.Close();
            }

        }
        //UPDATE dùng tham số

        public void UpdateService(string LDV_id,string money, DateTime start,DateTime end )
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "EXEC [dbo].[updateGiaDichVu]  @ldv_id1 = '" + LDV_id + "',@GDV_gia1 = '" + money + "',@start1 = '" + start + "', @end1 = '" + end + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
               
                con.Close();
            }
        }
        //UPDATE dùng object
        public void UpdateService( DTO.ServicePrice sp)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "EXEC [dbo].[updateGiaDichVu]  @ldv_id = '" + sp.LoaiDichVu + "',@dv='"+sp.DichVu+"',@money = '" + sp.Money+ "',@daystart = '" + sp.Start + "', @dayend = '" + sp.End + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Delete dùng tham số

        public void DeleteService(string LDV_id,string dv_id) 
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "EXEC [dbo].[deleteDichVu]  @ldv_id = '" + LDV_id + "',@dv_id='"+dv_id+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Delete dùng object
        public void DeleteService(DTO.Service service)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "EXEC [dbo].[deleteDichVu]  @ldv_id = '" + service.LoaiDichVu + "',@dv_id='" + service.DichVu + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public string loadServiceId()
        {
            int id;
            using (SqlConnection con = new SqlConnection())
            {    
                 con.ConnectionString = connect;
                 con.Open();
                 string sql = "select  count(DV_id) From DichVu";
                 DataSet db = new DataSet();
                 SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                 dap.Fill(db);
                 id = Convert.ToInt32(db.Tables[0].Rows[0][0]);
                 id++;
                 con.Close() ;
            }
            if (id >= 10)
               return  "DV" + id;
            else return "DV0" + id;
        }
    }
}
