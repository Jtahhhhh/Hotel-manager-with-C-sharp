using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Nevron.Nov.Windows.Forms;
using QKKS_ver_1._4_.DAL;
using Guna.UI2.WinForms;

namespace QKKS_ver_1._4_
{
    public partial class LoginKS : MetroFramework.Forms.MetroForm
    {
        DAL.Login l = new DAL.Login();
        public LoginKS()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginKS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LoginKS_Load(object sender, EventArgs e)
        {
            string path1 = AppDomain.CurrentDomain.BaseDirectory + "\\Picture\\LoginPic\\th.jpg";
            pictureBox1.Image = Image.FromFile(path1);
           
            //pictureBox1.Image = Image.FromFile("QKKS(ver 1.4)\\QLKS\\bin\\Picture\\LoginPic\\th.jpg");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            int code=l.checkLogin(txtLoginName.Text,txtPass.Text);
            if (code == 0)
            {
                mainMenu f = new mainMenu(login.getEMP(txtLoginName.Text));
                f.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
