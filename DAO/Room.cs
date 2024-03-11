using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAO
{
    public class Room
    {
        private static Room instance;
        public static int RoomWidth = 120;
        public static int RoomHeight = 120;
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        public static Room Instance
        {
            get { if ( Room.instance == null) instance = new Room() ; return Room.instance; }
            private set { Room.instance = value; }
        }
        private Room() { }

        public List<DTO.Room> LoadRoom()
        {
            List<DTO.Room> list = new List<DTO.Room>();

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect;
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Phong order by T_soTang ASC,P_soPhong ASC", con);
            sqlDataAdapter.Fill(dt);
            con.Close();

            foreach (DataRow item in dt.Rows) 
            {   
                DTO.Room r = new DTO.Room(item);
                list.Add(r);
            }
            return list;
        }
    }
}
