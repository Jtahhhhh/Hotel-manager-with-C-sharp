using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QKKS_ver_1._4_.DTO
{
    public class Room
    {
        string loaiPhong;
        int soPhong;
        int soTang;
        string ghiChu;
        string tinhTrang;
        public Room()
        {
            loaiPhong= "LP01";
            soPhong= 0;
            soTang= 0;
            ghiChu= string.Empty;
            tinhTrang= string.Empty;
        }
        public Room(string loaiPhong, int soPhong, int soTang, string ghiChu, string tinhTrang)
        {
            this.loaiPhong = loaiPhong;
            this.soPhong = soPhong;
            this.soTang = soTang;
            this.ghiChu = ghiChu;
            this.tinhTrang = tinhTrang;
        }
        public Room(Room room) { 
            this.loaiPhong=room.loaiPhong;
            this.soPhong=room.soPhong;
            this.soTang=room.soTang;
            this.ghiChu=room.ghiChu;
            this.tinhTrang=room.tinhTrang;
        }
        public Room(DataRow Row)
        {
            this.soTang = (int)Row["T_soTang"];
            this.soPhong = (int)Row["P_soPhong"];
            this.loaiPhong = Row["LP_id"].ToString();
            this.ghiChu = Row["P_ghiChu"].ToString();
            this.tinhTrang = Row["P_tinhTrang"].ToString();

        }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int SoPhong { get => soPhong; set => soPhong = value; }
        public int SoTang {  get => soTang; set => soTang = value; }
        public string GhiChu {  get => ghiChu; set => ghiChu = value; }
        public string TinhTrang {  get => tinhTrang; set => tinhTrang = value; }
    }
}
