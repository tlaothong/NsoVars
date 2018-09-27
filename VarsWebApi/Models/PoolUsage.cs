using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// การนำน้ำออกจากสระมาใช้
    /// </summary>
    public class PoolUsage
    {
      
        /// <summary>
        /// ใช้เครื่องสูบน้้าเพื่อสูบน้้าหรือไม่ (ถ้าไม่ใช้ ข้ามไปถามสระถัดไป)
        /// </summary>
        public bool PumpUsage { get; set; }
        /// <summary>
        /// บ่อนี้ใช้เครื่องสูบน้้ากี่เครื่อง
        /// </summary>
        public int PumpCount { get; set; }
        /// <summary>
        /// เครื่องสูบน้้าที่ใช้
        /// </summary>
        public List<Pump> Pump { get; set; }

         /// <summary>
        /// ใช้น้้าจากสระนี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public WaterActivity WaterActive { get; set; }

       
    }
}