namespace VarsWebApi.Models
{
    /// <summary>
    /// การเพราะปลูกไม้ดอก ไม้ประดับ
    /// </summary>
    public class FlowerCrop : ModelBase
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกไม้ดอกไม้ประดับ เพาะพันธุ์ไม้ หรือไม่ 
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
        /// ในรอบ 12 เดือนที่ผ่านมาที่แปลงนี้ปลูกไม้ ดอกไม้ประดับ เพาะพันธุ์ไม้ ชนิดใด  
        /// </summary>
        public string FlowerCropPerYear { get; set; }
        
        /// <summary>
        /// ลักษณะการปลูกเป็นแบบใด 
        /// </summary>
        public bool SingleCrop { get; set; }
        /// <summary>
        /// แบบปลูกปะปนกัน กับพืชชนิดอื่น ได้แก่ 
        /// </summary>
        public bool Mixed { get; set; }
        /// <summary>
        /// รายชื่อพืชที่ปลูกหลัก 
        /// </summary>
        public string MainPlanTingList { get; set; }
        /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง  
        /// </summary>
        public WaterSources WaterSource { get; set; }
    }
}