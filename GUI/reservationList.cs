using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using QKKS_ver_1._4_.DAO;
using QKKS_ver_1._4_.DAL;
using QKKS_ver_1._4_.DTO;

namespace QKKS_ver_1._4_
{
    public partial class reservationList : MetroFramework.Forms.MetroForm
    {
        DataProviceder dp = new DataProviceder();
        DAL.reservationList r = new DAL.reservationList();

        EMP emp;
        public reservationList(EMP eMP) : this()
        {
            emp = new EMP(eMP);
        }
        public reservationList()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reservationList_Load(object sender, EventArgs e)
        {
            
            
            string sql = "EXEC [dbo].[USP_GetReservationList] ";
            grid.DataSource=dp.loadGrid(sql);
            
           
        }

       
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = grid.CurrentRow.Cells["Mã"].Value.ToString();
            txtKHName.Text =  grid.CurrentRow.Cells["Tên Khách"].Value.ToString();
            txtLP.Text = grid.CurrentRow.Cells["Loại Phòng"].Value.ToString();
            txtNVName.Text = grid.CurrentRow.Cells["Người Lập"].Value.ToString();
            dateStart.Value = Convert.ToDateTime( grid.CurrentRow.Cells["Ngày Đặt"].Value);
            dateEnd.Value = Convert.ToDateTime(grid.CurrentRow.Cells["Ngày Trả"].Value);
           // txtNote.Text = grid.CurrentRow.Cells["Ghi Chú"].Value.ToString() ;
            dp.fillCb(cbFloor, "EXEC [dbo].[fillCBTang] @LP='"+txtLP.Text+"' ","T_soTang","T_soTang");
            dp.fillCb(cbRoom, "Select * from Phong where P_tinhTrang=N'Trống' and LP_id='" + r.loadLPId(txtLP.Text) + "' and T_soTang='" + cbFloor.SelectedValue + "' ", "P_soPhong", "P_soPhong");
            txtPrice.Text = r.LoadPrice(txtLP.Text);
        }

        private void cbLP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dp.fillCb(cbRoom, "Select * from Phong where P_tinhTrang=N'Trống' and LP_id='" + r.loadLPId(txtLP.Text) + "' and T_soTang='" + cbFloor.SelectedValue + "' ", "P_soPhong", "P_soPhong");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbRoom.Text == "") MessageBox.Show("Chưa chọn phòng");
            else
            {
                string sql = "exec[dbo].[createPNP] @id = '" + r.loadPNPId() + "',@note = '" + txtNote.Text + "',@nv_id = '" + r.loadNVHId(txtma.Text) + "',@kh_id = '" + r.loadMKHId(txtma.Text) + "',@pdp_id = '" + txtma.Text + "',@TD_start = '" + dateStart.Value + "',@TD_end = '" + dateEnd.Value + "',@P = '" + cbRoom.SelectedValue + "',@T = '" + cbFloor.SelectedValue + "',@LP_id = '" + r.loadLPId(txtLP.Text) + "'";
                r.checkRoom(cbRoom.SelectedValue.ToString(), cbFloor.SelectedValue.ToString(), sql);
                sql = "EXEC [dbo].[USP_GetReservationList] ";
                grid.DataSource = dp.loadGrid(sql);
            }
        }

        private void grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reservationList_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}
