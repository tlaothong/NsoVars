using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    // บ่อน้้าบาดาลส่วนตัว 
    /// <summary>
    /// ใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย +บิลค่าน้ำ
    /// </summary>
    public class AvgUsageWaterBill
    {
        /// <summary>
        ///  ใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย   
        /// </summary>
        public PrivateGroundWaterUsage UsageType { get; set; }
        /// <summary>
        ///  ลบ.ม./เดือน  
        /// </summary>
        public int UsageCubicMeters { get; set; }
        /// <summary>
        /// ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า 
        /// </summary>
        public int WaterBill { get; set; }

        /// <summary>
        /// ใช้เครื่องสูบน้้าเพื่อสูบน้้าหรือไม่ (ถ้าไม่ใช้ ข้ามไปถามสระถัดไป)
        /// </summary>
        public bool HasPump { get; set; }

        /// <summary>
        /// บ่อนี้ใช้เครื่องสูบน้้ากี่เครื่อง
        /// </summary>
        public int PumpCount { get; set; }
        
        /// <summary>
        /// เครื่องสูบน้้าที่ใช้
        /// </summary>
        public List<Pump> Pumps { get; set; }
        
        /// <summary>
        /// ใช้น้้าจากสระนี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public FarmWaterActivity UsageActivities { get; set; }

        /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        // TODO:  
        public bool HasQaulityProblem { get; set; }
        /// <summary>
        ///  มีปัญหา คือ  
        /// </summary>
        public Problem QualityProblems { get; set; }
    }
}    

