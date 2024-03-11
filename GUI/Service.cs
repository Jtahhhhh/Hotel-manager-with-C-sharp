using QKKS_ver_1._4_.DAO;
using QKKS_ver_1._4_.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace QKKS_ver_1._4_
{
    public partial class Service : MetroFramework.Forms.MetroForm
    {
        DataProviceder dp = new DataProviceder();
        DAL.Service s = new DAL.Service();
        DTO.Service service;
        DTO.ServicePrice SP;
        public Service()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Service_Load(object sender, EventArgs e)
        {
            string sql = "exec [dbo].[USP_GetServiceList]";
            gridService.DataSource = dp.loadGrid(sql);
            dp.fillCb(cbLDV,"select LDV_id,LDV_ten from LoaiDichVu", "LDV_ten", "LDV_id");
            txtMa.Text = s.loadServiceId();
        }

        private void gridService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text=gridService.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text= gridService.CurrentRow.Cells[1].Value.ToString();
            cbLDV.Text= gridService.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            service = new DTO.Service(Convert.ToString(cbLDV.SelectedValue), txtMa.Text, txtTen.Text);
            SP = new DTO.ServicePrice(Convert.ToString(cbLDV.SelectedValue), txtMa.Text, Convert.ToDateTime(cbDayTimeStrart.Text), Convert.ToDateTime(cbDayTimeEnd.Text), txtPrice.Text);
            s.AddService(service,SP);
            string sql = "exec [dbo].[USP_GetServiceList]";
            MessageBox.Show("Thêm thành công", "Thông báo");
            gridService.DataSource = dp.loadGrid(sql);
            txtMa.Text = s.loadServiceId();
        }

        private void btnCharnge_Click(object sender, EventArgs e)
        {
            SP = new DTO.ServicePrice(Convert.ToString(cbLDV.SelectedValue), txtMa.Text, Convert.ToDateTime(cbDayTimeStrart.Text), Convert.ToDateTime(cbDayTimeEnd.Text), txtPrice.Text);

            s.UpdateService(SP);
            string sql = "exec [dbo].[USP_GetServiceList]";
            MessageBox.Show("Cập nhật thành công", "Thông báo");
            gridService.DataSource = dp.loadGrid(sql);
            txtMa.Text = s.loadServiceId();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service = new DTO.Service(Convert.ToString(cbLDV.SelectedValue), txtMa.Text, txtTen.Text);
            
            s.DeleteService(service);
            string sql = "exec [dbo].[USP_GetServiceList]";
            MessageBox.Show("Xóa thành công", "Thông báo");
            gridService.DataSource = dp.loadGrid(sql);
            txtMa.Text = s.loadServiceId();
        }
    }
}
