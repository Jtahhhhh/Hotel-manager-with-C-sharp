using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.GUI
{
    public partial class reservationCreate : MetroFramework.Forms.MetroForm
    {
        DAO.DataProviceder dt = new DAO.DataProviceder();
        DAL.reservationCreate reservation = new DAL.reservationCreate();
        DTO.Room r;
        DTO.EMP emp;
        public reservationCreate(DTO.Room r, DTO.EMP e) : this()
        {

            this.r = new DTO.Room(r);
            
            this.emp = new DTO.EMP(e);
        }
        public reservationCreate( DTO.EMP e) : this()
        {

            this.emp = new DTO.EMP(e);
            this.r = new DTO.Room();
        }
        public reservationCreate()
        {
            InitializeComponent();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void reservationCreate_Load(object sender, EventArgs e)
        {
            txtMa.Text=""+ reservation.loadServiceId();
            dt.fillCb(cbFloor, "Select * from LoaiPhong", "LP_tenLoai", "LP_id");
            cbFloor.SelectedValue = r.LoaiPhong;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") { MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo"); }
            else if (txtPhone.Text == "") { MessageBox.Show("Chưa nhập số điện thoại khách hàng", "Thông báo"); }
            else if (dateStart.Text == "" || dateEnd.Text == "") { MessageBox.Show("Chưa nhập ngày đến hoặc ngày đi"); }
            else if (Convert.ToDateTime(dateStart.Text) < DateTime.Today) { MessageBox.Show("Không thể đặt phòng trong quá khứ"); }
            else if (Convert.ToDateTime(dateStart.Text) > Convert.ToDateTime(dateEnd.Text)) { MessageBox.Show("Lỗi nhập liệu:\nTrả phòng trước khi nhận", "Lỗi"); }
            else
            {
                reservation.addReservation(txtName.Text, txtPhone.Text, emp.Ma, Convert.ToInt32(txtMa.Text), rNote.Text, Convert.ToDateTime(dateStart.Text), Convert.ToDateTime(dateEnd.Text), cbFloor.SelectedValue.ToString());
                this.Close();
            }
        }
    }
}
