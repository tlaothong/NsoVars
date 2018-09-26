namespace VarsWebApi.Models
{
    /// <summary>
    /// น้ำบาดาล
    /// </summary>
    public class Underground
    {
        // TODO:Doing
        
        /// <summary>
        /// มีบ่อน้้าบาดาลส่วนตัวหรือไม่
        /// </summary>
        public bool PrivatePool{ get; set; }

        /// <summary>
        /// ถ้ามีบ่อน้้าบาดาลส่วนตัว มีจ้านวนกี่บ่อ 
        /// </summary>
        public int PoolCount { get; set; }

        /// <summary>
        ///  ในรอบ 12 เดือนที่ผ่านมา มีบ่อน้้าบาดาลที่ใช้อยู่กี่บ่อ 
        /// </summary>
        public int UsePoolCount { get; set; }

        /// <summary>
        ///  บ่อที่ 1 (ถามบ่อน้้าบาดาลที่ใช้อยู่ทีละบ่อ)  
        /// </summary>
        public PoolUsage PoolUsage { get; set; }

        // TODO: 5.2.4, 5.2.5, 5.2.6 Missing
        


        
    }
}