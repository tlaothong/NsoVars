using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ปัญหาอุทกภัย
    /// </summary>
    public class Disasterous
    {
        /// <summary>
        /// ในรอบ 5 ปีที่ผ่านมา (2556-2560) ที่อยู่อาศัยนี้ประสบปัญหาอุทกภัย (น้ำท่วมขัง น้ำรอการระบาย) หรือไม่
        /// </summary>
        public bool Flooded { get; set; }
    }
}
