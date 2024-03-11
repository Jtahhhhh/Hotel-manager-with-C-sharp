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
using QKKS_ver_1._4_.GUI;
using QKKS_ver_1._4_.DAO;
using QKKS_ver_1._4_.DAL;
using QKKS_ver_1._4_.DTO;

namespace QKKS_ver_1._4_
{
    public partial class mainMenu : MetroFramework.Forms.MetroForm
    {
        DataProviceder  dt =new DataProviceder();
      
        EMP emp;
        public mainMenu(EMP e): this()
        {
            emp = new DTO.EMP(e);
            label2.Text = "Chào mừng " + emp.Ten;
          
        }
        public mainMenu()
        {
            InitializeComponent();
        }
        #region Method
        void LoadRoom()
        {

        }
        #endregion

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service f = new Service();
            f.ShowDialog();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room(emp);
            DAL.mainMenu menu = new DAL.mainMenu(this.emp);
            int check = Convert.ToInt32(menu.checkCV(emp.Ma));
            if (check == 0)
                MessageBox.Show("Người Dùng không có quyền truy cập", "Thông báo");
            else
            {
                room.ShowDialog();
                this.Close();
            }
        }
       
        private void mainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            DAL.mainMenu menu = new DAL.mainMenu(this.emp);
           
            menu.LoadRoom(flRoom);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.EMPinfo nv = new GUI.EMPinfo();
            DAL.mainMenu menu = new DAL.mainMenu(this.emp);
            int check= Convert.ToInt32( menu.checkCV(emp.Ma));
            if (check == 0)
                MessageBox.Show("Người Dùng không có quyền truy cập", "Thông báo");
            else nv.ShowDialog();

        }

        private void daoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revenuead r = new Revenuead();
            DAL.mainMenu menu = new DAL.mainMenu(this.emp);
            int check = Convert.ToInt32(menu.checkCV(emp.Ma));
            if (check == 0)
                MessageBox.Show("Người Dùng không có quyền truy cập", "Thông báo");
            else  r.ShowDialog();
           
        }

        private void danhSaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reservationList list = new reservationList();
            list.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccInf f = new AccInf(emp);
            f.ShowDialog();
        }

        private void phòngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tạoĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.reservationCreate r = new GUI.reservationCreate(this.emp);
            r.ShowDialog(); 
        }

        private void giáPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.roomPrice r = new GUI.roomPrice();
            r.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.flRoom.Controls.Clear();
            DAL.mainMenu menu = new DAL.mainMenu(this.emp);

            menu.LoadRoom(flRoom);
        }
    }
}
