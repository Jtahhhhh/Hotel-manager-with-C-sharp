using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace QKKS_ver_1._4_.DAO
{
    public class DataProviceder
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        public DataTable loadGrid(string sql)
        {
            DataTable dt = new DataTable();
            using ( SqlConnection con = new SqlConnection()){
                con.ConnectionString = connect;
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public string load(string sql)
        {
            string code;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                code = cmd.ExecuteScalar().ToString();
                con.Close();
            }

            return code;
        }
        public void fillCb(ComboBox comb, string sql, string hienthi, string giatri)
            {
                
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connect;
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comb.DataSource = dt;
                    comb.DisplayMember = hienthi;
                    comb.ValueMember = giatri;
                    con.Close() ;
            }
            }
        public void fillCb(ComboBox comb, string sql, string hienthi1, string hienthi2, string giatri)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                comb.DataSource = dt;
                comb.DisplayMember = hienthi1+0+hienthi2;
                comb.ValueMember = giatri;
                con.Close();
            }
        }

    }
}
