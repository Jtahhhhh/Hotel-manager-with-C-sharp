using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QKKS_ver_1._4_.DAL;
using QKKS_ver_1._4_.DAO;
using QKKS_ver_1._4_.DTO;

namespace QKKS_ver_1._4_.GUI
{
    public partial class EMPinfo : MetroFramework.Forms.MetroForm  {

        DataProviceder dp = new DataProviceder();
        DAL.EMPinfo emp = new DAL.EMPinfo();
        public EMPinfo()
        {

            InitializeComponent();
        }
       

        private void EMPinfo_Load(object sender, EventArgs e)
        {
            dgEMP.DataSource = dp.loadGrid("select * from NhanVien");
        }

        private void EMPinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainMenu main= new  mainMenu();
            //main.Show();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "") MessageBox.Show("Chưa nhập mail");
            else if (txtName.Text == "") MessageBox.Show("Chưa nhập tên");
            else if (txtPass.Text == "") MessageBox.Show("Chưa nhập mật khảu");
            else if (txtPhoneNum.Text == "") MessageBox.Show("Chưa nhập số điện thoại");
            else if (txtRole.Text == "") MessageBox.Show("Chưa nhập chức vụ");
            else if (textBox7.Text == "") MessageBox.Show("Chưa nhập ngày sinh");
            else
            {
                emp.addNV(emp.loadMa(), txtName.Text, txtPhoneNum.Text, txtMail.Text, txtPass.Text, txtRole.Text, Convert.ToDateTime(textBox7.Text));
                dgEMP.DataSource = dp.loadGrid("select * from NhanVien");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "") MessageBox.Show("Chưa nhập mail");
            else if (txtName.Text == "") MessageBox.Show("Chưa nhập tên");
            else if (txtPass.Text == "") MessageBox.Show("Chưa nhập mật khảu");
            else if (txtPhoneNum.Text == "") MessageBox.Show("Chưa nhập số điện thoại");
            else if (txtRole.Text == "") MessageBox.Show("Chưa nhập chức vụ");
            else if (textBox7.Text == "") MessageBox.Show("Chưa nhập ngày sinh");
            else
            {
                emp.updateNV(emp.loadMa(txtMail.Text, txtName.Text, txtPhoneNum.Text), txtName.Text, txtPhoneNum.Text, txtMail.Text, txtPass.Text, txtRole.Text, Convert.ToDateTime(textBox7.Text));
                dgEMP.DataSource = dp.loadGrid("select * from NhanVien");
            }
        }

        private void dgEMP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMail.Text= dgEMP.CurrentRow.Cells[3].Value.ToString();
            txtName.Text = dgEMP.CurrentRow.Cells[1].Value.ToString();
            txtPhoneNum.Text = dgEMP.CurrentRow.Cells[2].Value.ToString();
            txtRole.Text = dgEMP.CurrentRow.Cells[5].Value.ToString() ;
            textBox7.Text = dgEMP.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
