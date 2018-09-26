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
        public bool DoingPrivatePool{ get; set; }

        /// <summary>
        /// ถ้ามีบ่อน้้าบาดาลส่วนตัว มีจ้านวนกี่บ่อ 
        /// </summary>
        public int PoolCount { get; set; }

        /// <summary>
        ///  ในรอบ 12 เดือนที่ผ่านมา มีบ่อน้้าบาดาลที่ใช้อยู่กี่บ่อ 
        /// </summary>
        public int UsePoolCount { get; set; }


        // TODO:
        /// <summary>
        /// ในรอบ 1 ปีที่ผ่านมา ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย 
        /// </summary>
        public int AvgUsageWater { get; set; }

        /// <summary>
        ///  ไม่ทราบ ถามค่าน้้า  
        /// </summary>
        public bool UnknowAskWaterBill { get; set; }
         /// <summary>
        ///  ถามค่าน้้า  
        /// </summary>
        public int WaterBill { get; set; }
        /// <summary>
        ///  ไม่ทราบ
        /// </summary>
        public bool Unknow { get; set; }


        /// <summary>
        ///  ใช้เครื่องสูบน้้าเพื่อสูบน้้าหรือไม่  
        /// </summary>
        public PoolUsage PoolUsage { get; set; }

        // TODO: 5.2.4, 5.2.5, 5.2.6 Missing
         /// <summary>
        ///  ใช้น้้าจากบ่อน้้าบาดาลสาธารณะหรือไม่ 
        /// </summary>
        public bool PublicUnderGround { get; set; }

        /// <summary>
        ///   ถ้าใช้น้้าบ่อน้้าบาดาลสาธารณะ ใช้จ้านวนกี่บ่อ 
        /// </summary>
        public int Count { get; set; }

         /// <summary>
        ///   ใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย
        /// </summary>
        public int UsePerMonth { get; set; }
         /// <summary>
        ///   ไม่ทราบ
        /// </summary>
        public bool UnknowUsePerMonth { get; set; }
        
        /// <summary>
        ///   บ่อที่ 1 (ถามบ่อน้้าบาดาลสาธารณะที่ใช้อยู่ทีละบ่อ) 
        /// </summary>
        public PoolUsage Pool { get; set; }
        


        
    }
}