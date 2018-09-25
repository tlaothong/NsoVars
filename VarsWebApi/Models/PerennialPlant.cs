namespace VarsWebApi.Models
{
    public class PerennialPlant : ModelBase
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกพืชยืนต้น ไม้ผล สวนป่า หรือไม่
        /// </summary>
        public bool Doing { get; set; }
        /// <summary>
        /// ตั้งอยู่ที่ใด
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ไร่ กี่งาน กี่ตารางวา 
        /// </summary>
        public Area Area { get; set; }

        /// <summary>
        /// ที่แปลงนี้ตั้งอยู่ในเขตชลประทานหรือไม่ 
        /// </summary>
        public bool IrrigationField { get; set; }

        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาที่แปลงนี้ปลูกพืช   ยืนต้น ไม้ผล สวนป่า ชนิดใด  (ระบุได้ไมเ่กิน 5 ชนิด)  
        /// </summary>
        public string PerennialPerYear { get; set; }
        /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง  
        /// </summary>
        public WaterSource WaterSource { get; set; }



    }
}