using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QKKS_ver_1._4_.DAO;

namespace QKKS_ver_1._4_.GUI
{
    public partial class Revenuead : MetroFramework.Forms.MetroForm
    {   
        DataProviceder dt = new DataProviceder();
        DAL.Revenue r = new DAL.Revenue();
       
        public Revenuead()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            string sql = "exec [dbo].[getHoaDon]";
            grid.DataSource = dt.loadGrid(sql);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string sql = "exec [dbo].[getHoaDonByDate] @start='"+start.Value.ToString("yyyy-MM-dd")+"',@end='"+end.Value.ToString("yyyy-MM-dd") + "'   ";
            grid.DataSource = dt.loadGrid(sql);
            txtDT.Text = r.sum(start.Value.ToString("yyyy-MM-dd"), end.Value.ToString("yyyy-MM-dd"));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string sql = "exec [dbo].[getHoaDonByDate] @start='" + start.Value.ToString("yyyy-MM-dd") + "',@end='" + end.Value.ToString("yyyy-MM-dd") + "'   ";
            r.ExportRevenue(dt.loadGrid(sql), "Thống Kê","Báo cáo Doanh Thu từ Ngày "+ start.Value.ToString("dd-MM-yyyy") + " Đến Ngày "+ end.Value.ToString("dd-MM-yyyy"));
        }
    }
}
