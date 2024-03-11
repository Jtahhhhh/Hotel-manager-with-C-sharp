using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QKKS_ver_1._4_.DTO
{
    public class PNP
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
        int id;
        string note;
        string manv;
        string makh;
        int PDP_id;
        DateTime start;
        DateTime end;
        int p;
        int t;
        
        public PNP() { }    
        public PNP(int id,string note,string manv,string makh,int PDP,DateTime start,DateTime end, int p,int t)
        {
            this.id = id;
            this.note = note;
            this.manv = manv;
            this.makh = makh;
            this.PDP_id = PDP;
            this.start = start;
            this.end = end;
            this.p = p;
            this.t = t;
        }
        public PNP(PNP pnp)
        {
            this.id =pnp.id;
            this.note = pnp.note;
            this.manv = pnp.manv;
            this.makh = pnp.makh;
            this.PDP_id = pnp.PDP_id;
            this.start = pnp.start;
            this.end = pnp.end;
            this.p = pnp.p;
            this.t = pnp.t;
        }
        public PNP(DataRow Row)
        {
            this.id = Convert.ToInt32( Row["PNP_id"]);
            this.note = Row["PNP_ghiChu"].ToString();
            this.manv = Row["NV_id"].ToString();
            this.makh = Row["KH_id"].ToString() ;
            this.PNP_id = Convert.ToInt32 (Row["PNP_id"]);
            this.start = Convert.ToDateTime( Row["TD_start"]);
            this.end = Convert.ToDateTime(Row["TD_end"]);
            this.p = Convert.ToInt32(Row["p_phong"]);
            this.T = Convert.ToInt32(Row["T_soTang"]);
        }

        public int Ma { get => id; set => id = value; }
        public string GhiChu { get => note; set => note = value; }
        public string Ma_NV { get =>manv; set => manv = value; }
        public string Ma_KH { get =>makh; set => makh = value; }
        public int PNP_id { get => PDP_id;set => PDP_id = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
        public int P { get => p; set => p = value; }
        public int T { get => t; set => t = value; }
        public PNP getPNP(int p,int t)
        {
            PNP pnp  = null;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();

                string sql = "exec [getPNP] @p='" +p + "',@t='"+t+"'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(dt);
                pnp = new PNP(dt.Rows[0]);

                con.Close();
            }
            return pnp;

        }
    }
}
