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
        public WaterPump PoolUsageRiver { get; set; }
        // <summary>
        /// ใช้น้้าจากสระนี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public WaterActivity2 WaterActivityPublicGroundWater { get; set; }
        /// <summary>
        /// ปัญหาคุณภาพน้้า
        /// </summary>
        public WaterProblem WaterProblem { get; set; }

    }
}