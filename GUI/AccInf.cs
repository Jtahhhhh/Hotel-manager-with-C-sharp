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
using QKKS_ver_1._4_.DTO;
using QKKS_ver_1._4_.DAL;

namespace QKKS_ver_1._4_
{
    public partial class AccInf : MetroFramework.Forms.MetroForm
    {
        EMP emp;
        public AccInf(EMP e): this()
        {
            emp = new EMP(e);
            labelName.Text = ""+ emp.Ten;
            txtMail.Text = emp.TaiKhoan;
            txtCV.Text = emp.ChucVu;
            txtPhoneNum.Text = emp.Sdt;
            textBox1.Text = emp.TaiKhoan;
            //label8.Text = emp.Ma;
          
        }
        public AccInf()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccInf_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.AccInf ac = new DAL.AccInf();
            ac.checkMK(emp.Ma,txtPass.Text,txtNewPass.Text);
        }
    }
}
