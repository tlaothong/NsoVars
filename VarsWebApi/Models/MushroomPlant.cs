namespace VarsWebApi.Models
{
    /// <summary>
    /// การเพาะเชื้อเห็ด
    /// </summary>
    public class MushroomPlant : ModelBase
    {
        /// <summary>
        ///  ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้เพาะเชื้อและปลูกเห็ด หรือไม่
        /// </summary>
        public bool Doing { get; set; }
        // TODO:Count
        /// <summary>
        ///  ตั้งอยู่ที่ใด (ตำบล อำเภอ จังหวัด)
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ไร่ กี่งาน กี่ตารางวา  เพิ่มตารางเมตร
        /// </summary>
        // TODO:SqM
        public Area Area { get; set; }
        /// <summary>
        /// ที่แปลงนี้ตั้งอยู่ในเขตชลประทานหรือไม่
        /// </summary>
        public bool IrrigationField { get; set; }
        /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง 
        /// </summary>
        public WaterSources WaterSource { get; set; }

    }

}