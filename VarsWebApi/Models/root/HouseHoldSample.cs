using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ครัวเรือน - หน่วยตัวอย่าง
    /// </summary>
    public class HouseHoldSample : ModelBase
    {
        /// <summary>
        /// ครัวเรือนที่อยู่อาศัย
        /// </summary>
        public Residential Rensidence { get; set; }
        /// <summary>
        /// การทำการเกษตร
        /// </summary>
        public Agriculture Agriculture { get; set; }
        /// <summary>
        /// การผลิตสินค้า
        /// </summary>
        public Factorial Factory { get; set; }
        /// <summary>
        /// การค้าและการบริการ
        /// </summary>
        public Commercial Commerce { get; set; }
        /// <summary>
        /// การใช้น้ำ
        /// </summary>
        public WaterUsage WaterUsage { get; set; }
        /// <summary>
        /// ปัญหาอุทกภัย
        /// </summary>
        public Disasterous Disaster { get; set; }
        // TODO: ผู้ให้ข้อมูล
        /// <summary>
        /// ข้อมูลพื้นฐานส่วนบุคคล
        /// </summary>
        public UserInfo UserInfo { get; set; }
    }
}
