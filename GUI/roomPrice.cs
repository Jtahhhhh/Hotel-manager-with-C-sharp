using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.GUI
{
    public partial class roomPrice : MetroFramework.Forms.MetroForm
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        DAL.roomPrice r = new DAL.roomPrice();
        public roomPrice()
        {
            InitializeComponent();
            this.LoadPrice();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region load
        public void LoadPrice()
        {
            

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *  from GiaPhong", con);
            sqlDataAdapter.Fill(dt);
            con.Close();

            foreach (DataRow item in dt.Rows)
            {
                DTO.RoomPrice r = new DTO.RoomPrice(item);
                if (r.LoaiPhong == "LP01") { txtDeluxePrice.Text = r.Money; dateStartDeluxe.Value = r.Start;dateEndDeluxe.Value = r.End; }
                if (r.LoaiPhong == "LP02") { txtSuperiorPrice.Text = r.Money; dateStartSuperior.Value = r.Start; dateEndSuperior.Value = r.End; }
                if (r.LoaiPhong == "LP03") { txtFamilyPrice.Text = r.Money; dateStartFamily.Value = r.Start; dateEndFamily.Value = r.End; }


            }

        }


        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            r.addRoomPrice(dateStartDeluxe.Value,dateEndDeluxe.Value,Convert.ToInt32( txtDeluxePrice.Text),dateStartSuperior.Value,dateEndSuperior.Value,Convert.ToInt32( txtSuperiorPrice.Text),dateStartFamily.Value,dateEndFamily.Value,Convert.ToInt32(txtFamilyPrice.Text));
        }

        private void txtDeluxePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số", "Thông báo");
            }

        }

        private void txtSuperiorPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số", "Thông báo");
            }

        }

        private void txtFamilyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số", "Thông báo");
            }

        }
    }
}
