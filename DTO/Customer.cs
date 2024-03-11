using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DTO
{
    public class Customer
    {
        string KH_id;
        string ten;
        string sdt;
        string TK;
        string MK;
        public Customer(string KH_id,string ten,string sdt,string tk, string mk) 
        {
            this.KH_id=KH_id;
            this.ten=ten;
            this.sdt=sdt;
            this.TK=tk;
            this.MK=mk;
        }
        public Customer(Customer customer) 
        {
            this.KH_id=customer.KH_id;
            this.ten=customer.ten;
            this.sdt=customer.sdt;
            this.TK=customer.TK;
            this.MK=customer.MK;
        }
        public Customer(DataRow Row)
        {
            this.KH_id= Row["KH_id"].ToString();
            this.ten = Row["KH_ten"].ToString();
            this.sdt = Row["KH_sdt"].ToString();
            this.TK = Row["KH_tk"].ToString() ;
            this.MK = Row["KH_mk"].ToString();

        }
        public string MaKhachHang {  get=>KH_id; set => KH_id=value; }
        public string TenKhachHang { get => ten; set => ten = value; }
        public string SoDienThoai {  get => sdt; set => sdt = value; }
        public string TaiKhoan {  get => TK; set => TK = value;}

    }
}
