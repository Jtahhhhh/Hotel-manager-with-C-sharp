using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DTO
{
    public class RoomPrice
    {
        string loaiPhong;
        DateTime start;
        DateTime end;
        string money;
        public RoomPrice(string loaiPhong, DateTime start, DateTime end, string money)
        {
            this.loaiPhong = loaiPhong;
            this.start = start;
            this.end = end;
            this.money = money;
        }
        public RoomPrice(RoomPrice r)
        {
            this.LoaiPhong = r.LoaiPhong;
            this.start = r.start;
            this.end = r.end;
            this.money=r.money;
        }
        public RoomPrice(DataRow Row)
        {
            this.LoaiPhong = Row["LP_id"].ToString();
            this.start = Convert.ToDateTime( Row["TD_batDau"]);
            this.end = Convert.ToDateTime(Row["TD_ketThuc"]);
            this.money = Row["GP_gia"].ToString();

        }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
        public string Money { get => money; set => money = value; }    
    }
}
