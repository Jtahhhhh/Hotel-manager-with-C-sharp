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


namespace QKKS_ver_1._4_.GUI
{
    public partial class Bill : MetroFramework.Forms.MetroForm
    {
      
        DataProviceder dt = new DataProviceder();
        DAL.Paid p = new DAL.Paid();
        DAL.Bill b = new DAL.Bill();
        PNP pnp;
        public Bill(PNP p): this()
        {
            this.pnp = new PNP(p);
        }
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            DTO.Customer cus = new Customer(b.getCus(pnp.Ma_KH));
            dt.fillCb(cbServiceKind, "select * from LoaiDichVu", "LDV_ten", "LDV_id");
            dt.fillCb(cbService, "select * from DichVu Where LDV_id='" + cbServiceKind.SelectedValue + "'", "DV_ten", "DV_id");
            lCheckIn.Text = pnp.Start.ToString();
            lCheckOut.Text = pnp.End.ToString();
            txtRoomPrice.Text = b.loadPrice(pnp.Ma).ToString();
            dgService.DataSource = dt.loadGrid("SELECT DV_ten as 'Tên Dịch Vụ' , sl as 'Số Lượng', GDV_gia*sl as 'Giá' from DichVu_thuoc_PhieuNhanPhong a , DichVu b, GiaDichVu c where a.DV_id=b.DV_id and b.DV_id = c.DV_id and a.PNP_id='" + pnp.Ma+"'");
            txtTotal.Text = (Convert.ToInt32( txtRoomPrice.Text) + Convert.ToInt32 (b.loadTotal(pnp.Ma))).ToString();
            textBox1.Text= pnp.Ma.ToString();
            textBox2.Text = cus.TenKhachHang; 
            textBox3.Text= cus.SoDienThoai;
            b.addTTTT(pnp.Ma, txtTotal.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            b.addService(cbService.SelectedValue.ToString(),cbServiceKind.SelectedValue.ToString(),pnp.Ma.ToString(),numericUpDown1.Value.ToString());
            b.addServicePrice(pnp.Ma, b.loadTotal(pnp.Ma).ToString());
            dgService.DataSource = dt.loadGrid("SELECT DV_ten as 'Tên Dịch Vụ' , sl as 'Số Lượng', GDV_gia*sl as 'Giá' from DichVu_thuoc_PhieuNhanPhong a , DichVu b, GiaDichVu c where a.DV_id=b.DV_id and b.DV_id = c.DV_id and a.PNP_id='" + pnp.Ma + "'");
            txtTotal.Text = (Convert.ToInt32(txtRoomPrice.Text) + Convert.ToInt32(b.loadTotal(pnp.Ma))).ToString();
        }

        private void dgService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbServiceKind_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            dt.fillCb(cbService, "select * from DichVu Where LDV_id='"+cbServiceKind.SelectedValue+"'", "DV_ten", "DV_id");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
            Paid p = new Paid(pnp.Ma,txtTotal.Text);
           
            p.ShowDialog();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int todayPrice = Convert.ToInt32( b.loadTodayPrice(pnp.Ma));
            int price = Convert.ToInt32(txtRoomPrice.Text);
            
            if(DateTime.Today < Convert.ToDateTime(lCheckOut.Text))
            {
                if ((price - todayPrice) > 0)
                   if( MessageBox.Show("Check out sớm hơn dự kiến" + Environment.NewLine + "Số Tiền cần hoàn là: " +((todayPrice+ Convert.ToInt32(b.loadTotal(pnp.Ma))) - (price-Convert.ToInt32(p.Load(pnp.Ma)))), "Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                b.checkOut(pnp.Ma, (todayPrice + Convert.ToInt32(b.loadTotal(pnp.Ma))));
                                this.Close();
                            }

                else if ((price - todayPrice) < 0)
                        if (MessageBox.Show("Check out sớm hơn dự kiến" + Environment.NewLine + "Số Tiền cần thanh toán là: " + ((todayPrice + Convert.ToInt32(b.loadTotal(pnp.Ma))) - (price - Convert.ToInt32(p.Load(pnp.Ma)))), "Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            b.checkOut(pnp.Ma, (todayPrice + Convert.ToInt32(b.loadTotal(pnp.Ma))));
                            this.Close();
                        }
            }
            else if (DateTime.Today > Convert.ToDateTime(lCheckOut.Text))
            {
                if ((price - todayPrice) > 0)
                   if( MessageBox.Show("Check out trễ hơn dự kiến" + Environment.NewLine + "Số Tiền cần hoàn là: " + ((todayPrice + Convert.ToInt32(b.loadTotal(pnp.Ma))) - (price - Convert.ToInt32(p.Load(pnp.Ma)))),"Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        b.checkOut(pnp.Ma, (todayPrice + Convert.ToInt32(b.loadTotal(pnp.Ma))));
                        this.Close();
                    }
                else if ((price - todayPrice) < 0)
                   if( MessageBox.Show("Check out trễ hơn dự kiến" + Environment.NewLine + "Số Tiền cần thanh toán là: " + ((todayPrice+ Convert.ToInt32(b.loadTotal(pnp.Ma))) - (price - Convert.ToInt32(p.Load(pnp.Ma)))),"Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                            b.checkOut(pnp.Ma, (todayPrice + Convert.ToInt32(b.loadTotal(pnp.Ma))));
                            this.Close();
                        }
            }
            else if (DateTime.Today == Convert.ToDateTime(lCheckOut.Text))
            {
                b.checkOut(pnp.Ma, (todayPrice + Convert.ToInt32(b.loadTotal(pnp.Ma))));
                MessageBox.Show("Trả Phòng Thành công","Quản Lý Khách Sạn");
                this.Close();
            }
        }
    }
}
