using System.Collections.Generic;

namespace VarsWebApi.Models
{
    /// <summary>
    /// น้ าจากแม่น้ า
    /// </summary>
    public class River
    {
        /// <summary>
        /// ใช้เครื่องสูบน้้าเพื่อสูบน้้าหรือไม่ (ถ้าไม่ใช้ ข้ามไปถามสระถัดไป)
        /// </summary>
        public bool PumpUsage { get; set; }

        /// <summary>
        /// บ่อนี้ใช้เครื่องสูบน้้ากี่เครื่อง
        /// </summary>
        public int PumpCount { get; set; }
        /// <summary>
        /// เครื่องสูบน้้าที่ใช้
        /// </summary>
        public List<Pump> Pump { get; set; }
        
        
        // <summary>
        /// ใช้น้้าจากสระนี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public FarmWaterActivity WaterActivityPublicGroundWater { get; set; }
        /// <summary>
        /// ปัญหาคุณภาพน้้า
        /// </summary>
        public WaterProblem WaterProblem { get; set; }

    }
}