namespace VarsWebApi.Models
{
    /// <summary>
    /// การนำน้ำออกจากสระมาใช้
    /// </summary>
    public class PoolUsage2
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
        public Pump2 Pump { get; set; }
    }
}