using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DTO
{
    public class EMP
    {
        string ma;
        string ten;
        string sdt;
        string tk;
        string mk;
        string chucVu;
        DateTime birth;

        public EMP(string ma, string ten, string sdt, string tk, string mk, string chucVu, DateTime birth)
        {
            this.ma = ma;
            this.ten = ten;
            this.sdt = sdt;
            this.tk = tk;
            this.mk = mk;
            this.chucVu = chucVu;
            this.birth = birth;
        }
        public EMP(DataRow Row)
        {
            this.ma = Row["NV_id"].ToString();
            this.tk = Row["NV_tk"].ToString();
            this.mk = Row["NV_mk"].ToString();
            this.sdt = Row["NV_sdt"].ToString();
            this.birth = Convert.ToDateTime(Row["NV_ngaySinh"]);
            this.ten = Row["NV_ten"].ToString();
            this.chucVu = Row["NV_chucVu"].ToString();

        }
        public EMP(EMP emp) 
        {
            this.ma = emp.ma;
            this.ten = emp.ten;
            this.sdt = emp.sdt;
            this.tk = emp.tk;
            this.mk = emp.mk;
            this.chucVu= emp.chucVu;
            this.birth = emp.birth;
        }
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string TaiKhoan { get => tk; set => tk = value; }
        public string MatKhau { get => mk; set => mk = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
