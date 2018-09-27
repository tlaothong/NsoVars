using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ในรอบ 1 ปีที่ผ่านมา ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย
    /// </summary>
    public class AvgUsageWater
    {
        /// <summary>
        ///   ลบ.ม./เดือน  
        /// </summary>
        public int CubicMeterPerMonth { get; set; }
        
        ///  ไม่ทราบ
        /// </summary>
        public bool Unknow { get; set; }

        /// <summary>
        ///  ใช้เครื่องสูบน้้าเพื่อสูบน้้าหรือไม่  
        /// </summary>
        public List<WaterPump> WaterPumpPrivateGroundWater { get; set; }
        
        // <summary>
        /// ใช้น้้าจากสระนี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public WaterActivity2 WaterActivityPublicGroundWater { get; set; }

        /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        // TODO:  
        public bool WaterQualityPrivateGroundWater { get; set; }
        /// <summary>
        ///  มีปัญหา คือ  
        /// </summary>
        public ProblemAdd ProblemPrivateGroundWater { get; set; }



    }
}