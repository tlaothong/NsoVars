using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    // บ่อน้้าบาดาลสาธารณะ PublicGroundWater
    /// <summary>
    /// ในรอบ 1 ปีที่ผ่านมา ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย
    /// </summary>
    public class AvgUsageWater
    {
        /// <summary>
        ///   ลบ.ม./เดือน  
        /// </summary>
        public int CubicMeterPerMonth { get; set; }
        
        /// <summary>
        ///  ไม่ทราบ
        /// </summary>
        public bool Unknow { get; set; }

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
        public WaterActivity UsageActivities { get; set; }

        /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        // TODO:  
        public bool HasQualityProblem { get; set; }
        /// <summary>
        ///  มีปัญหา คือ  
        /// </summary>
        public Problem QualityProblem { get; set; }



    }
}