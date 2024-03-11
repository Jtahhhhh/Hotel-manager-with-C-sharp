using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAL
{
    public class EMPinfo
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";


        public void addNV(string ma, string ten, string sdt, string tk, string mk, string chucVu, DateTime birth)
        {
            using (SqlConnection con = new SqlConnection()) 
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "insert into NhanVien Values('" + ma + "','" + ten + "','" + sdt + "','" + tk + "','" + mk + "','" + chucVu + "','"+birth+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd .ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo");
                con.Close();
            }
        }
        public void updateNV(string ma, string ten, string sdt, string tk, string mk, string chucVu, DateTime birth)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "update NhanVien set NV_ten='"+ten+"',NV_sdt='"+sdt+"',NV_chucVu='"+chucVu+"' where NV_id='"+ma+"'"; 
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo");
                con.Close();
            }
        }
        public string loadMa()
        {
            int id;
            using (SqlConnection con = new SqlConnection()) 
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select sum(NV_id) from NhanVien";
                SqlCommand cmd = new SqlCommand (sql, con);
                id= Convert.ToInt32 (cmd.ExecuteScalar());
                con.Close ();
            }
            if (id < 10)
                return "NV0" + id;
            else return "NV" + id;
        }
        public string loadMa(string tk,string ten,string sdt)
        {
            string id;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "select NV_id from NhanVien where NV_tk='"+tk+"' and NV_sdt='"+sdt+"' and NV_ten = '"+ten+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                id = cmd.ExecuteScalar().ToString();
                con.Close();
            }
        
                return id;
          
        }
    }
}
