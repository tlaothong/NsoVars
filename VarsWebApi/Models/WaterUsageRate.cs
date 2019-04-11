using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class WaterUsageRate
    {
        /// <summary>
        /// ครัวเรือน - หน่วยตัวอย่าง
        /// </summary>
        public HouseHoldSample Unit { get; set; }
        /// <summary>
        /// ประเภทบ้าน/อาคาร/สิ่งปลูกสร้าง
        /// </summary>
        public BuildingType BuildingType { get; set; }
        /// <summary>
        /// รายละเอียดของหน่วยงานแหล่งผลิตน้ำประปา
        /// </summary>
        public List<DetailOrgWaterSupply> WaterServices { get; set; }
    }
}