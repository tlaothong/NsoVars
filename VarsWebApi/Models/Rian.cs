namespace VarsWebApi.Models
{
    /// <summary>
    /// การกักเก็บน้าฝน ***แสดงข้อมูล ชนิดพืช/การผลิต/การบริการ ที่เลือกใช้น้าฝนที่กักเก็บไว้ 
    /// </summary>
    public class Rian
    {
        /// <summary>
        /// - ภาชนะกักเก็บ
        /// </summary>
        public PackageWater PackageWater { get; set; }
        
        /// <summary>
        /// - กิจกรรมการใช้น้า
        /// </summary>
        public WaterActivity WaterActive { get; set; }

    }
}