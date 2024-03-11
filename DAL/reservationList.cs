using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QKKS_ver_1._4_.DAL
{
    internal class reservationList
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";

        public DataTable loadGrid(DateTime d, string lp)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GetReservationListByDateAndLP";
                cmd.Parameters.AddWithValue("@lp_id", lp);
                cmd.Parameters.AddWithValue("@day", d);
                cmd.Connection = con;
            }
            return dt;
        }
        public string LoadPrice(string LP)
        {
            string price;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select GP_gia from GiaPhong a, LoaiPhong b where a.LP_id = b.LP_id and b.LP_tenLoai = '" + LP + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                price = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            return price;
        }
        public int loadPNPId()
        {
            int id;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select  count(PNP_id) From PhieuNhanPhong";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(db);
                id = Convert.ToInt32(db.Tables[0].Rows[0][0]);
                id++;
                con.Close();
            }
            return id;

        }
        public string loadMKHId(string PDP_id)
        {
            string id;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select  KH_id From PhieuDatPhong where PDP_id='"+PDP_id+"'";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(db);
                id = db.Tables[0].Rows[0][0].ToString();
                con.Close();
            }
            return id;

        }
        public string loadNVHId(string PDP_id)
        {
            string id;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select  NV_id From PhieuDatPhong where PDP_id='" + PDP_id + "'";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(db);
                id = db.Tables[0].Rows[0][0].ToString();
                con.Close();
            }
            return id;

        }
        public string loadLPId(string ten)
        {
            string id;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select  LP_id From LoaiPhong where LP_tenLoai='" + ten + "'";
                DataSet db = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(db);
                id = db.Tables[0].Rows[0][0].ToString();
                con.Close();
            }
            return id;

        }
      
        public void checkRoom(string P,string T,string sql)
        {
            using (SqlConnection con = new SqlConnection()) 
            {
                con.ConnectionString=connect;
                con.Open();
                string sql1 = "exec [dbo].[checkRoom] @P='"+P+"',@t='"+T+"'";
                SqlCommand cmd = new SqlCommand(sql1, con);
                int check = Convert.ToInt32(cmd.ExecuteScalar());
                if (check == 1)
                    this.AddPDP(sql);
                else MessageBox.Show("Lỗi nhận phòng!" + Environment.NewLine + "Hãy Chọn Phòng Khác");
                con.Close();
            }
        }
        public void AddPDP(string sql)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Nhận Phòng Thành Công");

            }
        }
    }
}
