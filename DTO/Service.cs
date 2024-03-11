using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DTO
{
    public class Service
    {
        string LDV;
        string DV;
        string ten;
        public Service(string LDV, string DV,string ten)
        {
            this.LDV = LDV;
            this.DV = DV;
            this.ten = ten;
        }
        public Service(Service DV)
        {
            this.LDV = DV.LDV;
            this.DV = DV.DV;
            this.ten = DV.ten;

        }
        public string LoaiDichVu { get => LDV; set => LDV = value; }
        public string DichVu { get => DV; set => DV = value; }
        public string Ten { get => ten;set => ten = value;}

    }
}
