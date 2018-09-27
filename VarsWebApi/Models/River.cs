namespace VarsWebApi.Models
{
    /// <summary>
    /// น้ าจากแม่น้ า
    /// </summary>
    public class River
    {
         /// <summary>
        ///  น้ าจากแม่น้ า/ล าคลอง/แหล่งน้ าสาธารณะ 
        /// </summary>
        public PoolUsage PoolUsageRiver { get; set; }
         /// <summary>
        /// ปัญหาคุณภาพน้้า
        /// </summary>
        public WaterProblem WaterProblem { get; set; }

    }
}