using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
using QKKS_ver_1._4_.DTO;
using QKKS_ver_1._4_.DAO;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using QKKS_ver_1._4_.GUI;

namespace QKKS_ver_1._4_.DAL
{
    public class mainMenu
    {
        DTO.EMP emp;
        DAL.Room room = new DAL.Room();
        DAO.DataProviceder dt = new DAO.DataProviceder();
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        public mainMenu(DTO.EMP e) 
        {
            emp= new EMP(e);
        }
        public void LoadRoom(FlowLayoutPanel fl )
        {
            List<DTO.Room> roomList = DAO.Room.Instance.LoadRoom();
            foreach (DTO.Room item in roomList) 
            {
                Button bn = new Button() { Width = DAO.Room.RoomWidth, Height = DAO.Room.RoomHeight };
                
                if(item.LoaiPhong=="LP01") bn.Text = "" + item.SoTang + "0" + item.SoPhong + "" + Environment.NewLine +"Deluxe Room" +Environment.NewLine + item.TinhTrang;
                else if(item.LoaiPhong == "LP02") bn.Text = "" + item.SoTang + "0" + item.SoPhong + "" + Environment.NewLine +"Superior Room" +Environment.NewLine + item.TinhTrang;
                else bn.Text = "" + item.SoTang + "0" + item.SoPhong + "" + Environment.NewLine +"Family Room" +Environment.NewLine + item.TinhTrang;
                bn.Tag = item;
                switch (item.TinhTrang)
                {
                    case "Trống":
                        bn.BackColor = Color.LightBlue;
                        bn.Click += btn_click_create;
                        break;
                    case "Đã Nhận":
                        bn.BackColor = Color.Red;
                        bn.Click += btn_clink_showBill;
                        break;
                    case "Chưa Nhận":
                        bn.BackColor = Color.Purple;
                        break;
                    case "Đã Đặt":
                        bn.BackColor = Color.Blue;
                        break;
                    case "Bão Trì":
                        bn.BackColor = Color.Gray;
                      
                        bn.Click += btn_click_fix;
                        break;
                    case "Dơ":
                        bn.BackColor = Color.LightSlateGray;
                        bn.Click += btn_click_clean;
                        break;

                }
                fl.Controls.Add(bn);

            }
        }
        public void btn_click_create(object sender, EventArgs e)
        {
            GUI.reservationCreate reservation = new GUI.reservationCreate((sender as Button).Tag as DTO.Room,emp);
            reservation.ShowDialog();
        }
        public void btn_clink_showBill(object sender, EventArgs e)
        {
            PNP p = new PNP();
            GUI.Bill b = new GUI.Bill(p.getPNP(((sender as Button).Tag as DTO.Room).SoPhong, ((sender as Button).Tag as DTO.Room).SoTang));
            b.ShowDialog();
            string trangThai = dt.load("Select P_tinhTrang from Phong where P_soPhong='"+((sender as Button).Tag as DTO.Room).SoPhong+"'and T_soTang='"+ ((sender as Button).Tag as DTO.Room).SoTang + "'");
            if (trangThai == "Dơ")
            {
                (sender as Button).BackColor = Color.LightSlateGray;
                (sender as Button).Click -= btn_clink_showBill;
                (sender as Button).Click += btn_click_clean;//(sender as Button).Tag as DTO.Room)
                (sender as Button).Text = "" +( (sender as Button).Tag as DTO.Room).SoTang + "0" + ((sender as Button).Tag as DTO.Room).SoPhong + "" + Environment.NewLine + "Family Room" + Environment.NewLine + "Dơ";

            }
        }
        public void btn_click_clean(object sender, EventArgs e)
        {
            if (MessageBox.Show("Phòng Đã Đã Sạch Xong?", "Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                room.updateRoom((sender as Button).Tag as DTO.Room);
                (sender as Button).BackColor = Color.LightBlue;
                (sender as Button).Click -= btn_click_clean;
                (sender as Button).Click += btn_click_create;
                (sender as Button).Text = "" + ((sender as Button).Tag as DTO.Room).SoTang + "0" + ((sender as Button).Tag as DTO.Room).SoPhong + "" + Environment.NewLine + "Family Room" + Environment.NewLine + "Trống";
                MessageBox.Show("Đã dọn");
            }

        }
        public void btn_click_fix(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Phòng Đã Bảo Trì Xong?", "Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              room.updateRoom((sender as Button).Tag as DTO.Room);
                (sender as Button).BackColor = Color.LightBlue;
                (sender as Button).Click -= btn_click_fix;
                (sender as Button).Click += btn_click_create;
                (sender as Button).Text = "" + ((sender as Button).Tag as DTO.Room).SoTang + "0" + ((sender as Button).Tag as DTO.Room).SoPhong + "" + Environment.NewLine + "Family Room" + Environment.NewLine + "Trống";

                MessageBox.Show("Đã sửa");

            }
        }
        public string checkCV(string manv)
        {
            string check;
            using(SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                string sql = "exec [dbo].[checkCV] @manv='" + manv + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                check = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            return check;
        }
    }
}
