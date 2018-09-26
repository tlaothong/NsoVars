namespace VarsWebApi.Models
{
    /// <summary>
    /// การบริหารจัดการน้ำ เพื่อการเกษตร
    /// </summary>
    public class ManagementForFarming
    {
        /// <summary>
        ///  ในหมู่บ้าน/ชุมชนแห่งนี้มีโครงการจัดการน้้าเพื่อการเกษตรชุมชน โดยใช้พื้นที่สาธารณะหรือไม่ (โครงการที่ใช้งบประมาณจากส่วนท้องถิ่น)  
        /// </summary>
        public bool HaveManagementForFarming { get; set; }

        /// <summary>
        ///  หาก “มี” มีกี่โครงการ
        /// </summary>
        public int ManagementForFarmingCount { get; set; }

        /// <summary>
        /// ชื่อโครงการ
        /// </summary>
        public string NameOfManagement { get; set; }

        /// <summary>
        /// ไร่
        /// </summary>
        public int Rai { get; set; }
        /// <summary>
        /// ตารางวา
        /// </summary>
        public int SqWa { get; set; }

        /// <summary>
        ///  จำนวนครัวเรือนที่เป็นสมาชิกโครงการมีจำนวนเท่าไร 
        /// </summary>
        public int HouseMember { get; set; }

        /// <summary>
        ///  โครงการใช้น้้าผิวดินปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ) 
        /// </summary>
        public int UpperGroundAVGPerMount { get; set; }

        /// <summary>
        ///   โครงการมีบ่อน้้าบาดาลจำนวนกี่บ่อ  
        /// </summary>
        public int UndergroundOfCount { get; set; }

        /// <summary>
        ///   โครงการใช้น้้าบาดาลปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ)  
        /// </summary>
        public int UndergroundAVGPerMount { get; set; }
    }
}