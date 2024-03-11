using QKKS_ver_1._4_.DAO;
using QKKS_ver_1._4_.DAL;
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
using System.Xml.Linq;

// Xử lý sự kiện click ComboBox
namespace QKKS_ver_1._4_
{
    public partial class Room : MetroFramework.Forms.MetroForm
    {
        DataProviceder dp = new DataProviceder();
        DAL.Room r = new DAL.Room();
        DTO.Room room;
        DTO.RoomPrice rp;

        EMP emp;
        public Room(EMP e) : this()
        {
            emp = new DTO.EMP(e);
         

        }
        public Room()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
           
            string sql = "exec [dbo].[getPhong]";
            dgShowRoom.DataSource = dp.loadGrid(sql);
            dp.fillCb(cbLP, "select LP_id,LP_tenLoai from LoaiPhong", "LP_tenLoai", "LP_id");
            dp.fillCb(cbFloor, "select * from Tang", "T_soTang", "T_soTang");
            DTO.RoomPrice Room = new DTO.RoomPrice(r.getPrice(cbLP.SelectedValue.ToString()));
            txtPrice.Text = Room.Money.ToString();
            dateStart.Value = Room.Start;
            dateEnd.Value = Room.End;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            room = new DTO.Room(Convert.ToString(cbLP.SelectedValue), Convert.ToInt32(txtRoom.Text), Convert.ToInt32(cbFloor.Text), txtNote.Text, cbStatus.Text);
            rp = new DTO.RoomPrice(Convert.ToString(cbLP.SelectedValue), dateStart.Value, dateEnd.Value, txtPrice.Text);
           /* DateTime datestart = dateStart.Value;
            DateTime dateend = dateEnd.Value;
            int soPhong = Convert.ToInt32 (txtRoom.Text);
            int soTang = Convert.ToInt32( cbFloor.SelectedValue);*/
            r.addRoom(room,rp);
            string sql = "exec [dbo].[getPhong]";
            dgShowRoom.DataSource = dp.loadGrid(sql);
          
          
        }

        private void btnCharnge_Click(object sender, EventArgs e)
        {
            room = new DTO.Room(Convert.ToString(cbLP.SelectedValue), Convert.ToInt32(txtRoom.Text), Convert.ToInt32(cbFloor.SelectedValue), txtNote.Text, Convert.ToString(cbStatus.Text));
            rp = new DTO.RoomPrice(Convert.ToString(cbLP.SelectedValue), dateStart.Value, dateEnd.Value, txtPrice.Text);
            /*
            DateTime datestart = dateStart.Value;
            DateTime dateend = dateEnd.Value;
            int soPhong = Convert.ToInt32(txtRoom.Text);
            int soTang = Convert.ToInt32(cbFloor.SelectedValue);*/

            r.updateRoom(room, rp, Convert.ToString(cbStatus.Text));
            string sql = "exec [dbo].[getPhong]";
            dgShowRoom.DataSource = dp.loadGrid(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            room = new DTO.Room(Convert.ToString(cbLP.SelectedValue), Convert.ToInt32(txtRoom.Text), Convert.ToInt32(cbFloor.SelectedValue), txtNote.Text, Convert.ToString(cbStatus.Text));
            rp = new DTO.RoomPrice(Convert.ToString(cbLP.SelectedValue), dateStart.Value, dateEnd.Value, txtPrice.Text);
            r.deleteroom(room, rp);
            string sql = "exec [dbo].[getPhong]";
            dgShowRoom.DataSource = dp.loadGrid(sql);

        }

        private void dgShowRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void cbLP_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgShowRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbFloor.Text = dgShowRoom.CurrentRow.Cells[0].Value.ToString();
            txtRoom.Text = dgShowRoom.CurrentRow.Cells[1].Value.ToString();
            cbLP.Text = dgShowRoom.CurrentRow.Cells[2].Value.ToString();
            DTO.RoomPrice Room = new DTO.RoomPrice(r.getPrice(cbLP.SelectedValue.ToString()));
            txtPrice.Text = "" + Room.Money.ToString();
            dateStart.Value = Room.Start;
            dateEnd.Value = Room.End;
        }

        private void cbLP_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void cbLP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DTO.RoomPrice Room = new DTO.RoomPrice(r.getPrice(cbLP.SelectedValue.ToString()));
            txtPrice.Text = Room.Money.ToString();
            dateStart.Value = Room.Start;
            dateEnd.Value = Room.End;
        }

        private void Room_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu m = new mainMenu(emp);
            m.Show();
            this.Close();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
