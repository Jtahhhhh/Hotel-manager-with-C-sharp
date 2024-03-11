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
    public partial class Paid : MetroFramework.Forms.MetroForm
    {
        int ma;
        string total;
        DAL.Paid p = new DAL.Paid();
        public Paid(int ma,string total):this ()
        {
            this.ma = ma;
            this.total = total;
        }
        public Paid()
        {
            InitializeComponent();
        }

        private void Paid_Load(object sender, EventArgs e)
        {
            textBox1.Text = total;
            txtTotal.Text = p.Load(ma);
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPaid.Text) <= Convert.ToInt32(txtTotal.Text))
            {
                p.pay(ma, txtPaid.Text);
                txtTotal.Text = p.Load(ma);
                txtPaid.Text = "0";
            }
            else MessageBox.Show("Lỗi Nhập Liệu: Thanh toán nhiều hơn phần tiền cần thanh toán");

        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số", "Thông báo");
            }

        }
    }
}
