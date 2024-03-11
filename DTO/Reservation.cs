using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DTO
{
    public class Reservation
    {
        int PDP_id;
        string PDP_note;
        DateTime ngayLap;
        string NV_id;
        string KH_id;
        DateTime ngayDat;
        DateTime ngayDi;

        public Reservation(int pDP_id, string pDP_note, DateTime ngayLap, string nV_id, string kH_id, DateTime ngayDat, DateTime ngayDi)
        {
            PDP_id = pDP_id;
            PDP_note = pDP_note;
            this.ngayLap = ngayLap;
            NV_id = nV_id;
            KH_id = kH_id;
            this.ngayDat = ngayDat;
            this.ngayDi = ngayDi;
        }
        public Reservation(Reservation reservation) 
        { 
            this.PDP_id = reservation.PDP_id;
            this.PDP_note= reservation.PDP_note;
            this.KH_id = reservation.KH_id;
            this.NgayLap = reservation.NgayLap;
            this.NV_id = reservation.NV_id;
            this.ngayDat= reservation.ngayDat;
            this.ngayDi= reservation.ngayDi;
        }
        public int Ma { get => PDP_id; set => PDP_id = value; }
        public string GhiChu {  get => PDP_note; set => PDP_note = value; }
        public DateTime NgayDat { get => NgayDat; set => NgayDat = value; }
        public string MaNhanVien { get => NV_id;set => NV_id = value; }
        public string MaKhachHang { get => KH_id; set => KH_id = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime NgayTra { get => ngayDi; set => ngayDi = value; }

    }
}
