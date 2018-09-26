namespace VarsWebApi.Models
{
    /// <summary>
    /// การนำน้ำออกจากสระมาใช้
    /// </summary>
    public class PoolUsage
    {
        // TODO:
        /// <summary>
        /// มีการนำน้ำออกจากสระมาใช้ปริมาณเท่าไรต่อเดือนโดยเฉลี่ย (ลบ.ม./เดือน) (ถ้าตอบได้ให้ข้ามไปข้อ 5) 6)
        /// </summary>
        public int AvgUsageWater { get; set; }
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
        public Pump Pump { get; set; }
    }
}