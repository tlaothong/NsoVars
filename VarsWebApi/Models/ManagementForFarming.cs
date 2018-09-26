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
        public int CountManagementForFarming { get; set; }

        /// <summary>
        /// ชื่อโครงการ
        /// </summary>
        public string NameOfManagement { get; set; }

        /// <summary>
        ///  พื้นที่ของโครงการมีกี่ไร่ กี่ตารางวา(หากมีหลายพื้นที่ให้รวมทุกที่) 
        /// </summary>
        public string AreaOfManagement { get; set; }

        /// <summary>
        ///  จ้านวนครัวเรือนที่เป็นสมาชิกโครงการมีจ้านวนเท่าไร 
        /// </summary>
        public int CountToHouse { get; set; }

        /// <summary>
        ///  โครงการใช้น้้าผิวดินปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ) 
        /// </summary>
        public int UpperGroundAVGPerMount { get; set; }

        /// <summary>
        ///   โครงการมีบ่อน้้าบาดาลจ้านวนกี่บ่อ  
        /// </summary>
        public int CountOfUnderground { get; set; }

        /// <summary>
        ///   โครงการใช้น้้าบาดาลปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ)  
        /// </summary>
        public int UndergroundAVGPerMount { get; set; }
    }
}