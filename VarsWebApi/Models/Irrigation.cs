namespace VarsWebApi.Models
{
    public class Irrigation
    {
        /// <summary>
        ///  มีการน้าน้้าจากชลประทานมาใช้ปริมาณ เท่าไรต่อเดือนโดยเฉลี่ย  
        /// </summary>
        public int IrrigationUsage{ get; set; }
        /// <summary>
        /// ไม่ทราบ 
        /// </summary>
        public bool Unknow { get; set; }


        /// <summary>
        /// ใช้เครื่องสูบน้้าเพื่อสูบน้้ามาใช้หรือไม่ 
        /// </summary>
        public PoolUsage PoolUsageIrrigation { get; set; }

        
    }
}