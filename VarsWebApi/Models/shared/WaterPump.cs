using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ***ปรากฏกิจกรรมเฉพาะที่ระบุไว้ก่อนหน้าว่าใช้น้้า
    /// </summary>
    public class WaterPump
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
       
        
    }
}