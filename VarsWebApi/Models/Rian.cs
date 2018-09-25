namespace VarsWebApi.Models
{
    /// <summary>
    /// 5.6) การกักเก็บน้าฝน ***แสดงข้อมูล ชนิดพืช/การผลิต/การบริการ ที่เลือกใช้น้าฝนที่กักเก็บไว้ จากตอนที่ 1-4
    ///*** เพิ่มภาชนะ / ลบภาชนะ
    /// </summary>
    public class Rian
    {
        /// <summary>
        /// - ภาชนะกักเก็บ
        /// </summary>
        public PackageWater packageWater { get; set; }
        
        /// <summary>
        /// - กิจกรรมการใช้น้า
        /// </summary>
        public WaterActivity waterActive { get; set; }

    }
}