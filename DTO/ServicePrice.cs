using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DTO
{
    public class ServicePrice
    {
        string LDV;
        string DV;
        DateTime start;
        DateTime end;
        string money;
        public ServicePrice(string lDV,string DV, DateTime start, DateTime end, string money)
        {
            this.LDV = lDV;
            this.DV = DV;
            this.start = start;
            this.end = end;
            this.money = money;
        }
        public ServicePrice(ServicePrice SP) 
        {
            this.LDV = SP.LDV;
            this.DV = SP.DV;
            this.start = SP.start;
            this.end = SP.end;
            this.money = SP.money;
        }
        public string LoaiDichVu { get => LDV; set => LDV = value; }
        public string DichVu { get =>DV; set => DV = value; }
        public DateTime Start {get=>start; set => Start = value; }
        public DateTime End { get => end; set => End = value; }
        public string Money { get => money; set => Money = value; }
    }
}
