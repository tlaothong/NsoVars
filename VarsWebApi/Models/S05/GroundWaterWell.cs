using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// บ่อบาดาล สำหรับข้อมูลบ่อบาดาลทั้งส่วนตัวและสาธารณะ
    /// </summary>
    public class GroundWaterWell
    {
        /// <summary>
        ///  ใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย   
        /// </summary>
        /// <remarks>
        /// 1.ทราบปริมาณน้้า
        /// 2.ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า
        /// 3.ไม่ทราบ
        /// </remarks>
        public GroundWaterUsage UsageType { get; set; }

        /// <summary>
        /// ปริมาณน้ำ ลบ.ม./เดือน  
        /// </summary>
        public int? CubicMeterPerMonth { get; set; }

        /// <summary>
        /// ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า 
        /// </summary>
        public int? WaterBill { get; set; }

        /// <summary>
        /// ใช้เครื่องสูบน้้าเพื่อสูบน้้าหรือไม่ (ถ้าไม่ใช้ ข้ามไปถามสระถัดไป)
        /// </summary>
        public bool HasPump { get; set; }

        /// <summary>
        /// บ่อนี้ใช้เครื่องสูบน้้ากี่เครื่อง
        /// </summary>
        public int? PumpCount { get; set; }

        /// <summary>
        /// เครื่องสูบน้้าที่ใช้
        /// </summary>
        public List<Pump> Pumps { get; set; }

        /// <summary>
        /// ใช้น้้าจากสระนี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public WaterActivity UsageActivities { get; set; }

        /// <summary>
        /// ปัญหาคุณภาพน้้า
        /// </summary>
        public WaterProblem QualityProblem { get; set; }
    }
}
