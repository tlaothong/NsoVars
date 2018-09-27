using System.Collections.Generic;

namespace VarsWebApi.Models
{
    /// <summary>
    ///  น้ำที่ซื้อมาใช้    ***แสดงข้อมูล ชนิดพืช/การผลิต/การบริการ ที่เลือกใช้น้าฝนที่กักเก็บไว้ จากตอนที่ 1-4
    /// </summary>
    // TODO: 
    public class Buying
    {
        /// <summary>
        /// บรรจุภัณฑ์
        /// </summary>
        public string NamePackage { get; set; }
        /// <summary>
        /// ขนาดของบรรจุภัณฑ์ (มิลลิลิตร/ลิตร)
        /// </summary>
        public double Size { get; set; }

        public List<FarmWaterActivity> WarterActivity { get; set; }
    }
}