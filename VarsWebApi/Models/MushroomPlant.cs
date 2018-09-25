namespace VarsWebApi.Models
{
    public class MushroomPlant : ModelBase
    {
        /// <summary>
        /// เพาะเชื้อและปลูกเห็ด
        /// </summary>
        public bool Mushroom { get; set; }
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้เพาะเชื้อและปลูกเห็ด หรือไม่  
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// ตั้งอยู่ที่ใด (ตำบล อำเภอ จังหวัด)
        /// </summary>
        public Area Area { get; set; }
        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ไร่ กี่งาน กี่ตารางวา  เพิ่มตารางเมตร
        /// </summary>
        public bool IrrigationField { get; set; }
        /// <summary>
        /// ที่แปลงนี้ตั้งอยู่ในเขตชลประทานหรือไม่
        /// </summary>
        public WaterSources WaterSource { get; set; }
        /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง 
        /// </summary>
    }

}