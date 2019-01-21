using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Department
    {
        public string _id { get; set; }
        public string Type { get; set; }
        public Properties Properties { get; set; }
        public Geometry Geometry { get; set; }
    }
    public class Properties
    {
        public int Fig_id { get; set; }
        public string Ea_code_14 { get; set; }
        public string Ea_type { get; set; }
        public string Com_name { get; set; }
        public string Tam_name { get; set; } //ตำบล
        public string Dis_name { get; set; } //อำเภอ
        public string Pro_name { get; set; } //จังหวัด
        public string Ea_remark { get; set; }
        public string Muni_name { get; set; }
        public string Upd_date { get; set; }
        public string Year { get; set; }
        public string Old_ea_ref { get; set; }
        public int Moo { get; set; }
        public int Hh_num { get; set; }
        public int Map_status { get; set; }
    }

    public class Geometry
    {
        public string Type { get; set; }
        public List<List<List<List<double>>>> Coordinates { get; set; }
    }

}
