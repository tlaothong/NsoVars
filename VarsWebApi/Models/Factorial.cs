using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// การผลิตสินค้า
    /// </summary>
    public class Factorial : ModelBase
    {
        /// <summary>
        /// ชื่อสถานประกอบการ / หน่วยงาน
        /// </summary>
        public string Name { get; set; }
        public string Category { get; set; }
        public int Totalworkers { get; set; }
        public bool HeavyMachine { get; set; }
        public WaterSources WaterSource { get; set; }
        public bool Wastewaterforcreateproductinmount { get; set; }
        public bool Wastewaterforcreateproduct { get; set; }
        public bool Wastewaterreuse { get; set; }
    }
    
}
